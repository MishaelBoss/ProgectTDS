using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(Collider))]
public class AidKit : MonoBehaviour
{
    public float healAmmo = 50;

    public AudioSource AudioSource;

    private void OnTriggerEnter(Collider other)
    {
        var playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.AddHealth(healAmmo);
            AudioSource.Play();
            Invoke("Destroy", 1f);
        }
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
