using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal17 : MonoBehaviour
{
    public void LoadNextScene()
    {
        Scene scene1 = SceneManager.GetActiveScene();

        int curScene = scene1.buildIndex;

        int nextScene = curScene + 1;

        SceneManager.LoadScene(nextScene);
    }
    private void OnTriggerEnter2D(Collider2D col)   
    {
        if (col.tag == "Player")
        {
            GameManager.Instance.CCount = 0;
            GameManager.Instance.speed = 1000f;
            GameManager.Instance.stageCount++;
            if(GameManager.Instance.stageCount % 4 == 0)
            {
                GameObject.Find("AD").GetComponent<AdmobInterstitialScript>().show();
            }
            LoadNextScene();
        }
    }
}
