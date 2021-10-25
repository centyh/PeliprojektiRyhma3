using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVolume : MonoBehaviour
{

    [Range(0.0f, 1.0f)]
    [SerializeField] private float masterVolume = 0.5f;


    void Update()
    {
        AudioListener.volume = masterVolume;
    }
}
