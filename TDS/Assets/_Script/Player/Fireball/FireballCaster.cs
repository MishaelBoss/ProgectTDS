using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    public Fireball fireball;

    public Transform pointCreateFireball;

    public float ShootSpeed;
    private float ShootTimer = 0.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) & ShootTimer <= 0)
            Shoot();

        if (ShootTimer > 0)
            ShootTimer -= Time.deltaTime;
    }

    void Shoot()
    {
        ShootTimer = ShootSpeed;
        Instantiate(fireball, pointCreateFireball.position, pointCreateFireball.rotation);
    }
}
