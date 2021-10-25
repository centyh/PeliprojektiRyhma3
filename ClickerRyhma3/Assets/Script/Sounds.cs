using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    private float musicVolume = 1f;

    public AudioSource audioSource;
    public AudioClip paperSound;


    private void Start()
    {
        audioSource.Play();
    }

    private void Update()
    {
        audioSource.volume = musicVolume;
    }

    public void UpdateVolume(float volume)
    {
        musicVolume = volume;
    }

    public void PaperSound()
    {
        audioSource.PlayOneShot(paperSound);
    }

}
