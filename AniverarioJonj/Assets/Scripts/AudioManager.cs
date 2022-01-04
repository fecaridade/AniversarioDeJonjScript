using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [SerializeField] private AudioSource _musicSource;
    public bool tocando;
        

    private void Awake()
    {
        
        Instance = this;
        
    }

    private void Update()
    {
        if (!_musicSource.isPlaying)
        {
            tocando = false;
        }
    }

    public void PlayMusic(AudioClip clip,float volume){
        if (!tocando)
        {
            _musicSource.PlayOneShot(clip,volume);
            tocando = true;
        }
        
        
    }

    public void PauseMusic()
    {
        _musicSource.Pause();
    }

    public void StopMusic()
    {
        tocando = false;
        _musicSource.Stop();
    }
    
}
