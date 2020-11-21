using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class option1 : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;

    public void Open1()
    {
        Panel.SetActive(true);
    }
    public void Close1()
    {
        Panel.SetActive(false);
    }
    public void Open2()
    {
        Panel2.SetActive(true);
    }
    public void Close2()
    {
        Panel2.SetActive(false);
    }

    public void load1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void load2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void load3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void load4()
    {
        SceneManager.LoadScene("Stage4");

    }
    public void load5()
    {
        SceneManager.LoadScene("Stage5");
    }
    public void load6()
    {
        SceneManager.LoadScene("Stage6");
    }
}
