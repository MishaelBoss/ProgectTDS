using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float damage = 50;
    public GameObject prefabs;
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Explosion", 1f);
    }

    void Explosion() { 
        Destroy(gameObject);
        var explosion = Instantiate(prefabs);
        explosion.transform.position = transform.position;
        explosion.GetComponent<Explosion>().damage = damage;
    }
}
