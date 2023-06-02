using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryAudio : MonoBehaviour
{
    private AudioSource victoryAudio;
    public void PlayAudio()
    {
        victoryAudio.Play();
    }
}
