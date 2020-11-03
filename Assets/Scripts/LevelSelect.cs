using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    /*// Use this for initialization
    void Start()
    {
        disableALL();
        // PlayerPrefs.DeleteALL();  
        if (!PlayerPrefs.HasKey("LevelClearedCount"))
            PlayerPrefs.SetInt("LevelClearedCount", 0);
        int clearedLavel = PlayerPrefs.GetInt("LevelClearedCount");
        for (int i = 0; i < clearedLavel + 1; ++i)
        {
            transform.GetChild(i).gameObject.GetComponent<Button>().interactable = true;
        }
    }

    // Update is called once per frame
    public void disableALL()
    {
        int levelButtonsCount = transform.childCount;
        for (int i = 0; i < levelButtonsCount; ++i)
        {
            transform.GetChild(i).gameObject.GetComponent<Button>().interactable = false;
        }
    }
    public void palyeLavel(int Lavel = 0)
    {
        SceneManager.LoadScene(Lavel);
    }*/
}