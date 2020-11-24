using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoSingleton<GameManager>
{
    public bool downCheck = false;

    public float speed = 500f;
    public int CCount = 0;
    public int currentLevel = 2;

    public StageData saveJson;

    public int touchCount = 0;
    public int stageCount = 0;

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