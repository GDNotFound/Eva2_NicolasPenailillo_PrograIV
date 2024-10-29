using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChanger : MonoBehaviour
{
    public AudioSource audioSrc;
    public float audioVolume = 1f;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }
    void Update()
    {
        audioSrc.volume = audioVolume;
    }
    public void SetVolume(float vol)
    {
        audioVolume = vol;
    }
}
