using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    private float musicVolume = 1f;

    private float soundsVolume = 1f;

    public AudioSource audioSource;
    public AudioSource paperSound;
    public AudioSource coinSound;
    public AudioSource woodSound;


    private void Start()
    {
        audioSource.Play();
    }

    private void Update()
    {
        audioSource.volume = musicVolume;
        coinSound.volume = soundsVolume;
        paperSound.volume = soundsVolume;
        woodSound.volume = soundsVolume;
    }

    public void UpdateVolume(float volume)
    {
        musicVolume = volume;
    }

    public void UpdateSFXVolume(float sfxVolume)
    {
        soundsVolume = sfxVolume;

    }

    public void PaperSound()
    {

    }

}
