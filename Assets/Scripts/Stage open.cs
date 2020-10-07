using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class option : MonoBehaviour
{
    public GameObject Panel;

    public void Open()
    {
        Panel.SetActive(true);
    }
    public void Close()
    {
        Panel.SetActive(false);
    }
}