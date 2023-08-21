using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class AudioComputer : MonoBehaviour
{
    private AudioSource audio;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject play;
    [SerializeField] private TextMeshProUGUI cronometro;
    private bool ativo = false;

    private int tempo;
    private int seg;
    private int min;

    private float segAtual = 0f;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update() {
        if(audio.isPlaying){
            this.tempo = (int)this.audio.time;
            this.seg = tempo % 60;
            this.min = (tempo / 60) % 60;
            if (seg < 10) this.cronometro.text = min.ToString() + ":0" + seg.ToString() + "/0:45";
            else this.cronometro.text = min.ToString() + ":" + seg.ToString() + "/0:45";
        }
    }

    public void AbrePlayer(){
        if(!ativo){
            this.player.SetActive(true);
            this.ativo = true;
            this.audio.Play();
            this.audio.time = segAtual;

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
            this.audio.time = segAtual;
            this.play.SetActive(false);
            this.pause.SetActive(true);
        }
    }

    public void PausaMusica(){
        if(audio.isPlaying){
            this.segAtual = this.audio.time;
            this.audio.Stop();

            this.play.SetActive(true);
            this.pause.SetActive(false);
        } else this.TocaMusica();
    }

    public void ResetaMusica(){
        if(audio.isPlaying){
            this.segAtual = 0;
            this.audio.time = segAtual;
        } else {
            this.segAtual = 0;
            this.audio.Play();
            this.audio.time = segAtual;
            this.play.SetActive(false);
            this.pause.SetActive(true);
        }
    }
}
