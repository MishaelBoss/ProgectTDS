using UnityEngine;
using UnityEngine.AI;

public class Health : MonoBehaviour
{
    public float valueHealth = 100;

    private PlayerProgress PlayerProgress;

    public bool isAlive() { 
        return valueHealth > 0;
    }

    private void Start()
    {
        PlayerProgress = FindObjectOfType<PlayerProgress>();
    }

    public void DealDamage(float damage) {

        valueHealth -= damage;

        PlayerProgress.AddExperience(damage);
        if (valueHealth <= 0)
        {
            Die();
        }
    }

    private void Die() {
        Destroy(gameObject);
        GetComponent<EnemyAI>().enabled = false;
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
    }
}
