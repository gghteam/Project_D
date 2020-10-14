using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal7 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            GameObject.Find("MainMenuControl").GetComponent<SJson>().stageData.CLevel += 1;
            SceneManager.LoadScene("Stage10");
        }
    }
}
