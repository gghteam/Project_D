using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartStage1 : MonoBehaviour
{

    public GameObject PauseUI;

    public void Restaret()
    {
        GameManager.Instance.CCount = 0;
        GameManager.Instance.speed = 1000f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        GameManager.Instance.CCount = 0;
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}