using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Jombie_Sound
{
    public string soundName;
    public AudioClip clip;
}

public class Enemy_Sound : MonoBehaviour
{
    [Header("사운드 등록")]
    [SerializeField] Jombie_Sound[] bgmSounds;

    [Header("브금 플레이어")]
    [SerializeField] AudioSource bgmPlayer;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    public void PlayBGM()
    {
        int random = Random.Range(0, 4); //찾은 좀비 목소리수 만큼 랜덤 ㄱ

        bgmPlayer.clip = bgmSounds[random].clip;
        bgmPlayer.Play();
    }
}