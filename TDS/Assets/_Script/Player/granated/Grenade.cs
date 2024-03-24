using UnityEngine;

public class Grenade : MonoBehaviour
{
    public GameObject prefabs;
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Explosion", 1f);
    }

    void Explosion() { 
        Destroy(gameObject);
        var explosion = Instantiate(prefabs);
        explosion.transform.position = transform.position;
    }
}
