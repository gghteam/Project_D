using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMg : MonoBehaviour
{
    public Text scoreText;

    private void Start()
    {
        //scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        
        scoreText.text = "충돌 횟수: " + GameManager.Instance.CCount + " /10";
    }
}
