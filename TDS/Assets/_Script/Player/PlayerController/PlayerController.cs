using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("ControllerPlayer")]
    [SerializeField] private float _speedRun = 5;
    [SerializeField] private float _speed = 2;
    [SerializeField] private float _speedmove = 1;
    public float _jumpForce;

    public float gravity = 9.8f;
    private float _fallVelocity = 0;

    private CharacterController _characterController;

    private Vector3 _moveVector;

    [Header("ControllPlayer")]
    public Type type;
    public enum Type { PC, Joystick }

    // Start is called before the first frame update
    void Start()
        => StartGetComponentCharacterController();

    void Update() => InputPlayerControllerUpdate();

    void FixedUpdate() => PlayerPhysicsFixedUpdate();

    void StartGetComponentCharacterController()
    => _characterController = GetComponent<CharacterController>();

    void InputPlayerControllerUpdate() {
        _moveVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            _moveVector += transform.forward;

        if (Input.GetKey(KeyCode.S))
            _moveVector -= transform.forward * _speedmove;

        if (Input.GetKey(KeyCode.A))
            _moveVector -= transform.right * _speedmove;

        if (Input.GetKey(KeyCode.D))
            _moveVector += transform.right * _speedmove;

        if (Input.GetKeyUp(KeyCode.Space) && _characterController.isGrounded)
            _fallVelocity = -_jumpForce;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _characterController.Move(_moveVector * _speedRun * Time.fixedDeltaTime);
        }
    }

    void PlayerPhysicsFixedUpdate() {
        _characterController.Move(_moveVector * _speed * Time.fixedDeltaTime);

        _fallVelocity += gravity * Time.fixedDeltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);

        if (_characterController.isGrounded)
            _fallVelocity = 0;
    }
}
