using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Verifica : MonoBehaviour
{
    private int numeroChaves = 0;
    private bool cadeadoVerificado = false;
    private bool photoVerificado = false;
    [SerializeField] private Text answerDigit1;
    [SerializeField] private Text answerDigit2;
    [SerializeField] private Text answerDigit3;
    [SerializeField] private Text answerDigit4;
    [SerializeField] private Text cadeadoDigit1;
    [SerializeField] private Text cadeadoDigit2;
    [SerializeField] private Text cadeadoDigit3;
    [SerializeField] private Text cadeadoDigit4;
    [SerializeField] private Text cadeadoDigit5;
    [SerializeField] private GameObject panelCadeado;
    [SerializeField] private GameObject openCadeado;
    [SerializeField] private SpriteRenderer spritePortaFechada;
    [SerializeField] private Sprite spritePortaAberta;
    [SerializeField] private GameObject fourDigits;
    [SerializeField] private GameObject portaFechada;
    [SerializeField] private GameObject portaAberta;
    [SerializeField] private GameObject marteloInv;
    [SerializeField] private GameObject martelo;
    [SerializeField] private GameObject slot1;
    [SerializeField] private GameObject slot2;
    [SerializeField] private GameObject slot3;
    [SerializeField] private GameObject slot4;
    [SerializeField] private GameObject slot5;
    [SerializeField] private GameObject slot6;
    [SerializeField] private GameObject chave1;
    [SerializeField] private GameObject chave2;
    [SerializeField] private GameObject chave3;
    [SerializeField] private GameObject chaveInv;
    [SerializeField] private GameObject chaveTrio;
    [SerializeField] private GameObject chaveParte1;
    [SerializeField] private GameObject chaveParte2;
    [SerializeField] private GameObject chaveParte3;
    [SerializeField] private GameObject photoFind;
    [SerializeField] private GameObject cabeceiraAntes;
    [SerializeField] private GameObject cabeceiraDepois;
    

    [SerializeField] private DisplayImage displayImage;

    public void Update(){
        VerificaDigit4();
        if(!photoVerificado)
        {
            VerificaPhotoFind();
        }
        if(!cadeadoVerificado)
        {
            VerificaCadeado();
        }
        if(numeroChaves == 4)
        {
            this.chaveInv.SetActive(true);
            this.chaveTrio.SetActive(false);
        }
    }

    public void VerificaDigit4(){
        if((answerDigit1.text == "1")&&(answerDigit2.text == "9")&&(answerDigit3.text == "4")&&(answerDigit4.text == "5"))
        {
            this.fourDigits.SetActive(false);
            this.portaFechada.SetActive(false);
            this.portaAberta.SetActive(true);
            this.martelo.SetActive(true);
            Actions.OnStoryAdvanced(3);

            //Para impedir que o loop se repita
            this.answerDigit1.text = "0";
        }
    }

    public void VerificaCadeado(){
        if((cadeadoDigit1.text == "8")&&(cadeadoDigit2.text == "5")&&(cadeadoDigit3.text == "6")&&(cadeadoDigit4.text == "4")&&(cadeadoDigit5.text == "9"))
        {
            this.spritePortaFechada.sprite = spritePortaAberta;
            this.chave1.SetActive(true);
            this.panelCadeado.SetActive(false);
            this.openCadeado.SetActive(false);
            this.numeroChaves++;
            cadeadoVerificado = true;
        }
    }

    public void VerificaPhotoFind () 
    {
        if((slot1.transform.localPosition == new Vector3(-583, 379, slot1.transform.localPosition.z)) && (slot2.transform.localPosition == new Vector3(7, 320, slot2.transform.localPosition.z)) && (slot3.transform.localPosition == new Vector3(642, 380, slot3.transform.localPosition.z)) && (slot4.transform.localPosition == new Vector3(-603, -439, slot4.transform.localPosition.z)) && (slot5.transform.localPosition == new Vector3(-7, -492, slot5.transform.localPosition.z)) && (slot6.transform.localPosition == new Vector3(617, -439, slot6.transform.localPosition.z)))
        {
            this.displayImage.TurnOffPhotoFind();
            this.cabeceiraAntes.SetActive(false);
            this.cabeceiraDepois.SetActive(true);
            this.chave3.SetActive(true);
            this.numeroChaves++;
            this.photoVerificado = true;
            Actions.OnStoryAdvanced(8);
        }
       
    }

    public void SomeChave1()
    {
        this.chave1.SetActive(false);
    }
    public void SomeChave2()
    {
        this.numeroChaves++;
        this.chave2.SetActive(false);
    }
    public void SomeChave3()
    {
        this.chave3.SetActive(false);
    }


    public void PegaMartelo(){
        this.martelo.SetActive(false);
        this.marteloInv.SetActive(true);
    }

    public void PegaChave()
    {
        if(numeroChaves == 1)
        {
            this.chaveParte1.SetActive(true);
        }
        else if(numeroChaves == 2)
        {
            this.chaveParte2.SetActive(true);
        }
        else if(numeroChaves == 3)
        {
            this.chaveParte3.SetActive(true);
            this.numeroChaves = 4;
        }
    }
}
