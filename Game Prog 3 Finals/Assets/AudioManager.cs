using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public GameObject canvas;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource[] audioSources;
    public AudioSource audioSource;
    void Awake() {
    if  (instance == null){
        instance = this;
        audioSources = GetComponents<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }
    else{
        Destroy(gameObject);
    }
}

public AudioSource BGMAudioSource(){
    return audioSources[0];
}
public AudioSource SFXAudioSource(){
    return audioSources[3];
}

  
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void GUISFX(AudioClip sfx)
    {
        audioSource.PlayOneShot(sfx, 1);
    }
    public void StopAudio()
    {
        audioSource.Stop();
    }
    public void PlayAudio()
    {
        audioSource.Play();
    }
    public void PauseAudio()
    {
        audioSource.Pause();
    }
    public void ChangeAudio(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
