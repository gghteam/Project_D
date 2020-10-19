﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoSingleton<GameManager>
{
    public bool downCheck = false;

    public float speed = 1000f;
    public float CCount = 0f;
    public int currentLevel = 2;

    private void Update()
    {
        if(CCount > 9)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            CCount = 0;
            speed = 1000f;
        }
    }

}