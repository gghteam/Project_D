using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string sonudName;
    public AudioClip clip;
}
public class SoundManager : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    [Header("사운드 등록")]
    [SerializeField] Sound[] bgmSounds;

    [Header("BGM 플레이어")]
    [SerializeField] AudioSource bgmPlayer;


    // Start is called before the first frame update
    void Start()
    {
        PlayRamdomBGM();
    }

    public void PlayRamdomBGM()
    {
        int random = Random.Range(0, 2);
        bgmPlayer.clip = bgmSounds[random].clip;
        bgmPlayer.Play();
    }
}
