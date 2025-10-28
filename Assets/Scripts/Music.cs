using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip LifeWillChange;
    public AudioSource playMusic;
    
    public void PlayMusic(){
        playMusic.Play();
        playMusic.loop = true;
        }
        
    public void StopMusic(){
        playMusic.Stop();
    }
}
