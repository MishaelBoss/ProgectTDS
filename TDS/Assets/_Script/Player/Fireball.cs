using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 2;

    public float lifeTime = 0.0f;

    private void Start() => Invoke("DestroyFireball", lifeTime);

    void FixedUpdate() => MoveFixedUpdate();

    void MoveFixedUpdate() => transform.position += transform.forward * speed * Time.fixedDeltaTime;

    void OnCollisionEnter(Collision collision) => DestroyFireball();

    void DestroyFireball()
    {
          Destroy(gameObject);
    }
}
