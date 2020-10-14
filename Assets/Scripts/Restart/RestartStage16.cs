﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartStage16 : MonoBehaviour
{

    public GameObject PauseUI;

    public void Restaret()
    {
        SceneManager.LoadScene("Stage16");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}