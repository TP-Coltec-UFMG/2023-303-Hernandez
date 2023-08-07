using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnHover : MonoBehaviour
{
    public AudioSource _sounds;
    public AudioClip _hover;

    public void HoverSound(){
        _sounds.PlayOneShot(_hover);
    }

}
