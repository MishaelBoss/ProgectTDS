using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform CameraAxis;

    public int minAxis;
    public int maxAxis;

    public int RotationSpeed;

    void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X"), 0);

        var newAngleX = CameraAxis.localEulerAngles.x - Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse Y");

        if (newAngleX > 180)
            newAngleX -= 360;

        newAngleX = Mathf.Clamp(newAngleX, minAxis, maxAxis);

        CameraAxis.localEulerAngles = new Vector3(newAngleX, 0, 0);
    }
}
