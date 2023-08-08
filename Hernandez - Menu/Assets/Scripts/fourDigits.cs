using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fourDigits : MonoBehaviour
{
    private int currentNum;
    [SerializeField] private Text number;

    public void Start(){
        number.text = currentNum.ToString();
    }

    public void UpArrow(){
        if (currentNum < 9){
            this.currentNum++;
        }
        else{
            this.currentNum = 0;
        }
        number.text = currentNum.ToString();
    }
    public void DownArrow(){
        if (currentNum > 0){
            this.currentNum--;
        }
        else{
            this.currentNum = 9;
        }
        number.text = currentNum.ToString();
    }
}
