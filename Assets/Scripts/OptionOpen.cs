using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionOpen : MonoBehaviour
{
    public GameObject Panel;

    public void Open1()
    {
        Panel.SetActive(true);
    }
    public void Close1()
    {
        Panel.SetActive(false);
    }
}