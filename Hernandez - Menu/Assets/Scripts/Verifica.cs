using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Verifica : MonoBehaviour
{
    [SerializeField] private Text answerDigit1;
    [SerializeField] private Text answerDigit2;
    [SerializeField] private Text answerDigit3;
    [SerializeField] private Text answerDigit4;
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
    [SerializeField] private GameObject photoFind;
    [SerializeField] private GameObject cabeceiraAntes;
    [SerializeField] private GameObject cabeceiraDepois;

    [SerializeField] private DisplayImage displayImage;

    public void Update(){
        VerificaDigit4();
        VerificaPhotoFind();
    }

    public void VerificaDigit4(){
        if((answerDigit1.text == "1")&&(answerDigit2.text == "9")&&(answerDigit3.text == "4")&&(answerDigit4.text == "5"))
        {
            this.fourDigits.SetActive(false);
            this.portaFechada.SetActive(false);
            this.portaAberta.SetActive(true);
        }
    }

    public void VerificaPhotoFind () 
    {
        if((slot1.transform.localPosition == new Vector3(-583, 379, slot1.transform.localPosition.z)) && (slot2.transform.localPosition == new Vector3(7, 320, slot2.transform.localPosition.z)) && (slot3.transform.localPosition == new Vector3(642, 380, slot3.transform.localPosition.z)) && (slot4.transform.localPosition == new Vector3(-603, -439, slot4.transform.localPosition.z)) && (slot5.transform.localPosition == new Vector3(-7, -492, slot5.transform.localPosition.z)) && (slot6.transform.localPosition == new Vector3(617, -439, slot6.transform.localPosition.z)))
        {
            this.displayImage.TurnOffPhotoFind();
            this.cabeceiraAntes.SetActive(false);
            this.cabeceiraDepois.SetActive(true);
        }
       
    }

    public void PegaMartelo(){
        this.martelo.SetActive(false);
        this.marteloInv.SetActive(true);
    }
}
