using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerTeste : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    
    [SerializeField] private AudioClip audioClipA;
    [SerializeField] private AudioClip audioClipS;
    [SerializeField] private AudioClip audioClipD;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) TocarSom(1);
        if (Input.GetKeyDown(KeyCode.S)) TocarSom(2);
        if (Input.GetKeyDown(KeyCode.D)) TocarSom(3);
    }

    private void TocarSom(int i)
    {
        switch (i)
        {
            case 1: audioSource.PlayOneShot(audioClipA); break;
            case 2: audioSource.PlayOneShot(audioClipS); break;
            case 3: audioSource.PlayOneShot(audioClipD); break;
        }
        
        audioSource.Play();
    }
}
