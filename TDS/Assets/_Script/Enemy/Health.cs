using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int value = 100;

    [Header("UI")]
    public Slider SliderHelth;
    public Canvas canvas;

    private void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (value <= 0)
            Die();
    }

    private void OnCollisionEnter(Collision collision)
    {
        canvas.gameObject.SetActive(true);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
