using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int _value = 100;

    [Header("UI")]
    public Slider SliderHelth;
    public Canvas canvas;

    private void Start()
    {
        SliderHelth.value = _value;
        canvas.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (_value <= 0)
            Die();
    }

    private void OnCollisionEnter(Collision collision)
    {
        canvas.gameObject.SetActive(true);
    }

    void Die()
        => Destroy(gameObject);
}
