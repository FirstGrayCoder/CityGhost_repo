using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController2 : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    //public AudioClip explode;
    // Start is called before the first frame update
    void Start()
    {
        audioSource1.Stop();
        audioSource2.Stop();
        audioSource3.Play();
    }
    private void PlayOne()
    {
        audioSource1.Play();
        audioSource2.Stop();
        audioSource3.Stop();
    }
    private void PlayTwo()
    {
        audioSource1.Stop();
        audioSource2.Play();
        audioSource3.Stop();
    }
    private void PlayThree()
    {
        audioSource1.Stop();
        audioSource2.Stop();
        audioSource3.Play();
    }


}
