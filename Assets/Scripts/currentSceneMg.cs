using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class currentSceneMg : MonoBehaviour
{
    public Text sceneText;

    [System.Obsolete]
    void Update()
    {
        sceneText.text = Application.loadedLevelName;
    }
}
