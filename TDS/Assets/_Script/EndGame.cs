﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public float gameEnd = 0;

    private void Update()
    {
        if (gameEnd == 50) {
            SceneManager.LoadScene("EndGame");
        }
    }
}
