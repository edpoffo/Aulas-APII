using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(AudioSource))]
public class RandomSound : MonoBehaviour
{
    [SerializeField] private List<AudioClip> sons;

    [SerializeField, Range(0.2f, 2f)] private float minPitch = 0.8f;
    [SerializeField, Range(0.2f, 2f)] private float maxPitch = 1.2f;
    
    private AudioSource _audioSource;
    private bool willRandomPitch = false;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.E)) PlayRandomSound();
        //if(Input.GetKeyDown(KeyCode.A)) willRandomPitch = !willRandomPitch;
    }

    public void PlayRandomSound()
    {
        Debug.Log("Chamou da animação");
        
        var randomIndex = Random.Range(0,sons.Count);
        
        _audioSource.clip = sons[randomIndex];
        _audioSource.Play();
        
        var randomPitch = Random.Range(minPitch, maxPitch);
        _audioSource.pitch = randomPitch;
    }
}
