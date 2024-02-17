using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSource : MonoBehaviour
{
    public Transform targetPoint;

    private void Update()
    {
        transform.LookAt(targetPoint.position);
    }
}
