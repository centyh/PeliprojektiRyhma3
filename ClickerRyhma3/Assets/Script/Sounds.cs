using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip paperSound;


    public void PaperSound()
    {
        audioSource.PlayOneShot(paperSound);
    }

}
