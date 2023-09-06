using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class AudioComputer : MonoBehaviour
{
    private AudioSource audioPC;
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
        audioPC = GetComponent<AudioSource>();
    }

    private void Update() {
        if(audioPC.isPlaying){
            this.tempo = (int)this.audioPC.time;
            this.seg = tempo % 60;
            this.min = (tempo / 60) % 60;
            if (seg < 10) this.cronometro.text = min.ToString() + ":0" + seg.ToString() + "/0:40";
            else this.cronometro.text = min.ToString() + ":" + seg.ToString() + "/0:40";
        }
    }

    public void AbrePlayer(){
        if(!ativo){
            this.player.SetActive(true);
            this.ativo = true;
            this.audioPC.Play();
            this.audioPC.time = segAtual;

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
        if(audioPC.isPlaying) return;
        else if (ativo){
            this.audioPC.Play();
            this.audioPC.time = segAtual;
            this.play.SetActive(false);
            this.pause.SetActive(true);
        }
    }

    public void PausaMusica(){
        if(audioPC.isPlaying){
            this.segAtual = this.audioPC.time;
            this.audioPC.Stop();

            this.play.SetActive(true);
            this.pause.SetActive(false);
        } else this.TocaMusica();
    }

    public void ResetaMusica(){
        if(audioPC.isPlaying){
            this.segAtual = 0;
            this.audioPC.time = segAtual;
        } else {
            this.segAtual = 0;
            this.audioPC.Play();
            this.audioPC.time = segAtual;
            this.play.SetActive(false);
            this.pause.SetActive(true);
        }
    }
}
