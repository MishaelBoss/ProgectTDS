using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    public Fireball fireballPrf;

    public Transform pointCreateFireball;

    public float damage = 10;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    void Shoot()
    {
        var fireball = Instantiate(fireballPrf, pointCreateFireball.position, pointCreateFireball.rotation);
        fireball.damage = damage;
    }
}
