using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLevel : MonoBehaviour
{

    public GameObject PauseUI;

    public void Restaret()
    {
        SceneManager.LoadScene("Level");
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