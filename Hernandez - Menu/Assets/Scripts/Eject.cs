using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eject : MonoBehaviour
{
    //[SerializeField] private GameObject chave;
    [SerializeField] private GameObject painel;
    public void Ejetar(){
        //this.chave.SetActive(true);
        this.painel.SetActive(true);
    }

    public void Fechar(){
        this.painel.SetActive(false);
    }
}
