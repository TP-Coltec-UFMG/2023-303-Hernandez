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
        if((slot1.transform.localPosition == new Vector3(-420, 635, slot1.transform.localPosition.z)) && (slot2.transform.localPosition == new Vector3(0, 635, slot2.transform.localPosition.z)) && (slot3.transform.localPosition == new Vector3(425, 635, slot3.transform.localPosition.z)) && (slot4.transform.localPosition == new Vector3(-420, 310, slot4.transform.localPosition.z)) && (slot5.transform.localPosition == new Vector3(0, 310, slot5.transform.localPosition.z)) && (slot6.transform.localPosition == new Vector3(425, 310, slot6.transform.localPosition.z)))
        {
            this.photoFind.SetActive(false);
        }
        
    }

    public void PegaMartelo(){
        this.martelo.SetActive(false);
        this.marteloInv.SetActive(true);
    }
}
