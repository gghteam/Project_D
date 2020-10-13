using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControl : MonoBehaviour
{
    public Button Stage2, Stage3,Stage4,Stage5,Stage6,Stage7;
    int levelPassed;

    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPasssed");
        Stage2.interactable = false;
        Stage3.interactable = false;
        Stage4.interactable = false;
        Stage5.interactable = false;
        Stage6.interactable = false;
        Stage7.interactable = false;

        switch (levelPassed)
        {
            case 1:
                Stage2.interactable = true;
                break;
            case 2:
                Stage2.interactable = true;
                Stage3.interactable = true;
                break;
            case 3:
                Stage2.interactable = true;
                Stage3.interactable = true;
                Stage4.interactable = true;
                break;
            case 4:
                Stage2.interactable = true;
                Stage3.interactable = true;
                Stage4.interactable = true;
                Stage5.interactable = true;
                break;
            case 5:
                Stage2.interactable = true;
                Stage3.interactable = true;
                Stage4.interactable = true;
                Stage5.interactable = true;
                Stage6.interactable = true;
                break;
            case 6:
                Stage2.interactable = true;
                Stage3.interactable = true;
                Stage4.interactable = true;
                Stage5.interactable = true;
                Stage6.interactable = true;
                Stage7.interactable = true;
                break;
        }
    }
    public void stageToLoad (int level)
    {
        SceneManager.LoadScene(level);
    }

}
