using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoundOff : MonoBehaviour
{
    public Button btnOn;
    public Button btnOff;

    // Use this for initialization
    void Start()
    {
        btnOn = GetComponent<Button>();
        btnOff = GetComponent<Button>();

        btnOn.onClick.AddListener(() => PlayAudio());
        btnOff.onClick.AddListener(() => StopAudio());
    }

    void PlayAudio()
    {
        AudioListener.volume = 0.5f;
    }

    void StopAudio()
    {
        AudioListener.volume = 0f;
    }
}