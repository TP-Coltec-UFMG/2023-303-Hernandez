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

    public void Update(){
        VerificaDigit4();
    }

    public void VerificaDigit4(){
        if((answerDigit1.text == "1")&&(answerDigit2.text == "9")&&(answerDigit3.text == "4")&&(answerDigit4.text == "5"))
        {
            this.fourDigits.SetActive(false);
        }
    }


}
