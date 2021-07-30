using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAudio : MonoBehaviour
{
    public AudioClip _clip;
    public void Awake()
    {
        AudioManager.instance.ChangeAudio(_clip);
    }
   
}
