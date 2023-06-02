using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSourceBackgroundMusic;
    public AudioClip backgroundMusic;
    private void Start() {
        audioSourceBackgroundMusic.clip=backgroundMusic;
        audioSourceBackgroundMusic.loop=true;
        audioSourceBackgroundMusic.Play();
    }
}
