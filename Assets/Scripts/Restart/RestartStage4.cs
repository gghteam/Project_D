using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartStage4 : MonoBehaviour
{

    public GameObject PauseUI;

    public void Restaret()
    {
        SceneManager.LoadScene("Stage4");
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