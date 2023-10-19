using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    private AudioSource audioSrc;

    [SerializeField]
    private AudioClip sound;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        audioSrc.PlayOneShot(sound);
    }
}
