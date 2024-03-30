using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 2;

    public float lifeTime = 0.0f;

    public float damage = 10;

    private void Start() => Invoke("DestroyFireball", lifeTime);

    void FixedUpdate() => MoveFixedUpdate();

    void MoveFixedUpdate() 
        => transform.position += transform.forward * speed * Time.fixedDeltaTime;

    void OnCollisionEnter(Collision collision) {
        DamageEnemy(collision);
        DestroyFireball(); 
    }

    void DestroyFireball() 
        => Destroy(gameObject);

    void DamageEnemy(Collision collision) {
        var enemyHelht = collision.gameObject.GetComponent<Health>();
        if (enemyHelht != null)
        {
            enemyHelht.DealDamage(damage);
        }

        DestroyFireball();
    }
}
