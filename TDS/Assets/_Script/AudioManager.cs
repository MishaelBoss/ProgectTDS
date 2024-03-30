using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Replic")]
    public AudioClip Hello;

    [Range(0f, 1f)]
    public float volume;
    public AudioSource audioSource;

    private void Start()
        => GetComponent<AudioSource>().volume = volume;

    public void ReplicHello() 
        => audioSource.PlayOneShot(Hello);
}
