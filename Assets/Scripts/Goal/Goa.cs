using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goa : MonoBehaviour
{
    //private LevelSelect levelS;
    private void Start()
    {
        //levelS = new LevelSelect();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            GameManager.Instance.CCount = 0;
            GameManager.Instance.speed = 1000f;
            GameManager.Instance.saveJson.CLevel += 1;
            SceneManager.LoadScene("Stage2");
        }
    }
}
