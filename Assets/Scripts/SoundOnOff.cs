using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    AudioSource audio;

    bool isSound = true;
    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public void OnClickSoundButton()
    {
        if (isSound)
        {
            audio.volume = 0;
            isSound = false;
        }

        else
        {
            audio.volume = (float)0.1;
            isSound = true;
        }

    }
}
