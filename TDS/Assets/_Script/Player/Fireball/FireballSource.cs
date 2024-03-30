using UnityEngine;

public class FireballSource : MonoBehaviour
{
    public Transform targetPoint;
    public Camera cameraLink;

    public int distance;

    public InputCheck scr;

    private void Update() { RAYCASTUpdate(); CheckInputMouse();  }

    void RAYCASTUpdate() {

        var ray = cameraLink.ViewportPointToRay(new Vector3(0.5f, 0.7f, 0));

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            targetPoint.position = hit.point;
        else
            targetPoint.position = ray.GetPoint(distance);

        transform.LookAt(targetPoint.position);
    }

    void CheckInputMouse() {
        if (scr.mouse == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
