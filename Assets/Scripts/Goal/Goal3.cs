using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            GameManager.Instance.CCount = 0;
            GameManager.Instance.speed = 1000f;
            SceneManager.LoadScene("Stage6");
        }
    }
}
