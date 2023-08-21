using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioComputer : MonoBehaviour
{
    private AudioSource audio;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject play;
    private bool ativo = false;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void AbrePlayer(){
        if(!ativo){
            this.player.SetActive(true);
            this.ativo = true;
            this.audio.Play();

            this.play.SetActive(false);
            this.pause.SetActive(true);
        }
    }
    public void FechaPlayer(){
        if(ativo){
            this.player.SetActive(false);
            this.ativo = false;
            this.PausaMusica();
        }
    }

    public void TocaMusica(){
        if(audio.isPlaying) return;
        else if (ativo){
            this.audio.Play();
            this.play.SetActive(false);
            this.pause.SetActive(true);
        }
    }

    public void PausaMusica(){
        if(audio.isPlaying){
            this.audio.Stop();

            this.play.SetActive(true);
            this.pause.SetActive(false);
        } else this.TocaMusica();
    }
}
