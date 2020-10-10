using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoSingleton<GameManager>
{
    public bool downCheck = false;
    public float speed = 1000f;
   
}

public class game_manager : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
