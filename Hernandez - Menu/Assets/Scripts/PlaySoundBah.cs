using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundBah : MonoBehaviour
{
    [SerializeField] private AudioSource _clip;

    void Start()
    {
        this._clip.Play();
    }

    public void Parar()
    {
        this._clip.Stop();
    }
}
