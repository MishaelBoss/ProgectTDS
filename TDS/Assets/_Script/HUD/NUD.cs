using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class NUD : MonoBehaviour
{
    [Header("UI")]
    public GameObject panelTab;

    [Header("Script")]
    public InputCheck scr;

    /*void Start()
        => Example();

    void Example() 
        => scr = GetComponent<InputCheck>();*/

    void Update()
    {
        checkBoolTab();
    }

    void checkBoolTab() {
        if (scr.tab == true) 
            panelTab.SetActive(true);
        else panelTab.SetActive(false);
    }
}
