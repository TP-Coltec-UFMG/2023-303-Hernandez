using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cadeado : MonoBehaviour
{
    private int currentNum;
    [SerializeField] private Text number;

    public void Start(){
        number.text = currentNum.ToString();
    }

    public void ChangeNumber(){
        if (currentNum < 9){
            this.currentNum++;
        }
        else{
            this.currentNum = 0;
        }
        number.text = currentNum.ToString();
    }

}
