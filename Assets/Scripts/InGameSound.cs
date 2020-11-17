using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameSound : MonoBehaviour
{
    private SoundOnOff s;

    void Start()
    {

        s = GameObject.Find("SoundManager").GetComponent<SoundOnOff>();
    }

    public void OnclickSoundButton2()
    {
        s.OnClickSoundButton();
    }

    void Update()
    {
        
    }
}
