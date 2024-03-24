﻿using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float damage = 50;
    public float maxSize = 5;
    public float speed = 1;

    void Start()
        => transform.localScale = Vector3.zero;


    void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * speed;
        if(transform.localScale.x > maxSize)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        var playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null) {
            playerHealth.DealDamage(damage);
        }

        var enemyHealth = other.GetComponent<Health>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }
}
