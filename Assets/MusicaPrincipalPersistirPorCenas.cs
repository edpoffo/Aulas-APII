using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaPrincipalPersistirPorCenas : MonoBehaviour
{
    public static MusicaPrincipalPersistirPorCenas Instance;
    [SerializeField] private List<AudioClip> musicas;
    private int indexMusica = 0;
    
    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            _audioSource = GetComponent<AudioSource>();
            
            DontDestroyOnLoad(gameObject);
            
            _audioSource.clip = musicas[indexMusica];
            _audioSource.Play();
        }
        else Destroy(gameObject);
    }

    private void Update()
    {
        VerificarMusica();
    }

    private void VerificarMusica()
    {
        if (!_audioSource.isPlaying)
        {
            indexMusica = (indexMusica + 1) % musicas.Count;
            
            _audioSource.clip = musicas[indexMusica];
            _audioSource.Play();
        }
    }
}
