using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackQuit : MonoBehaviour
{
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                // 할꺼 하셈
                Application.Quit();
            }
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
