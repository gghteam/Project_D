using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SJson : MonoBehaviour
{
    public StageData stageData;

    [ContextMenu("To Json Data")]
    public void SaveStageDataToJson()
    {
        string jsonData = JsonUtility.ToJson(stageData, true);
        string path = Path.Combine(Application.dataPath,"/stageData.json");
        File.WriteAllText(path, jsonData);
        Debug.Log("저장");
    }
    [ContextMenu("From Json Data")]
    public void LoadStageDataFromJson()
    {
        string path = Path.Combine(Application.dataPath, "/stageData.json");
        string jsonData = File.ReadAllText(path);
        stageData = JsonUtility.FromJson<StageData>(jsonData);
    }
    
    public void stageToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }
}

[System.Serializable]
public class StageData
{
    public Button[] Stage;
    public int levelmax = 7;
    public int CLevel = 1;
}