using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour{
    private AudioSource _audioSource;

    public float minPitch = 0.8f;
    public float maxPitch = 1.2f; 

    private void Awake() {
        _audioSource = GetComponent<AudioSource>();
    }
    
    public void Call(){
        _audioSource.pitch = Random.Range(minPitch,maxPitch);
        _audioSource.Play();
    }
}