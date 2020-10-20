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

    public StageData saveJson;

    private void Start()
    {
       saveJson = new StageData();
    }

    private void Update()
    {
        if(CCount > 9)
        {
            CCount = 0;
            speed = 1000f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}