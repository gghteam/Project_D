using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SJson : MonoBehaviour
{
    public StageData stageData;

    private readonly string SAVE_FILE_NAME = "Savefile.txt";
    private string filePath = "";

    private string savedJson = "";
    /*[ContextMenu("To Json Data")]

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
    }*/

    public void stageToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }
    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
        stageData = new StageData();
        filePath = string.Concat(Application.persistentDataPath, "/", SAVE_FILE_NAME);
    }
    public void OnClickSave()
    {
        Debug.Log("filePath : " + filePath);
        savedJson = JsonUtility.ToJson(stageData);
        Debug.Log("SavedJson : " + savedJson);
        FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
        byte[] data = Encoding.UTF8.GetBytes(savedJson);
        fs.Write(data, 0, data.Length);
        fs.Close();
    }

    public void OnClickLoad()
    {
        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
        byte[] data = new byte[fs.Length];
        fs.Read(data, 0, data.Length);
        fs.Close();
        savedJson = Encoding.UTF8.GetString(data);
        stageData = JsonUtility.FromJson<StageData>(savedJson);
    }

    private void OnApplicationQuit()
    {
        //SaveStageDataToJson();
        OnClickSave();
    }
    
}

[System.Serializable]
public class StageData
{
    public Button[] Stage;
    public int levelmax = 18;
    public int CLevel = 0;
}