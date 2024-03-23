using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public Rigidbody prefabs;
    public Transform Transform;

    public float Force = 200;
    void Update()
    {
        CheckInputButtonCretaeGranate();
    }

    void CheckInputButtonCretaeGranate() {
        if (Input.GetMouseButtonDown(1)) { 
            var granade = Instantiate(prefabs);
            granade.transform.position = Transform.position;
            granade.GetComponent<Rigidbody>().AddForce(Transform.forward * Force);
        }
    }
}
