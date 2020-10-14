﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goa : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            GameObject.Find("MainMenuCotrol").GetComponent<StageData>().CLevel += 1;
            SceneManager.LoadScene("Stage2");
        }
    }
}
