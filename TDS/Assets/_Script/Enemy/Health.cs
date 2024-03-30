using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public floatf value = 100;

    /*[Header("UI")]
    public Slider SliderHelth;
    public Canvas canvas;*/

    private PlayerProgress PlayerProgress;

    public bool isAlive() { 
        return value > 0;
    }

    private void Start()
    {
        /*SliderHelth.value = value;
        canvas.gameObject.SetActive(false);*/
        PlayerProgress = FindObjectOfType<PlayerProgress>();
    }

    public void DealDamage(float damage) {
        PlayerProgress.AddExperience(damage);

        //SliderHelth.value -= damage;
        if (value <= 0) {
            Destroy(gameObject);
        }
    }

    /*private void OnCollisionEnter(Collision collision)
        => canvas.gameObject.SetActive(true);*/

    void Die()
        => Destroy(gameObject);
}
