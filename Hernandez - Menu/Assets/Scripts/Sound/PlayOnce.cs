using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnce : MonoBehaviour
{
    public AudioSource _sounds;
    public AudioClip _sound;

    public void PlaySound(){
        _sounds.PlayOneShot(_sound);
    }
}
