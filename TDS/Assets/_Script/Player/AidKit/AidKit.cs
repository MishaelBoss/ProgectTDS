using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(Collider))]
public class AidKit : MonoBehaviour
{
    public float healAmmo = 50;

    private void OnTriggerEnter(Collider other)
    {
        var playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.AddHealth(healAmmo);
            Destroy(gameObject);
        }
    }
}
