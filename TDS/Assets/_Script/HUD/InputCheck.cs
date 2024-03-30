using UnityEngine;

public class InputCheck : MonoBehaviour
{
    [Header("Bool")]
    public bool tab;

    [Header("General")]
    public bool mouse;

    [Header("Input")]
    public KeyCode OpenTab = KeyCode.Tab;

    void Update()
    {
        CheckInputTab();
    }

    void CheckInputTab() {
        if (Input.GetKeyDown(OpenTab))
        {
            tab = !tab;
            mouse = !mouse;
        }
    }
}
