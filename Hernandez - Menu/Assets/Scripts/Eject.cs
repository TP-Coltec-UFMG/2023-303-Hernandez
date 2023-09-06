using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eject : MonoBehaviour
{
    //[SerializeField] private GameObject chave;
    [SerializeField] private GameObject painel;
    [SerializeField] private GameObject chave2;
    [SerializeField] private GameObject buttonEject;
    public void Ejetar(){
        //this.chave.SetActive(true);
        this.painel.SetActive(true);
        this.chave2.SetActive(true);
        this.buttonEject.SetActive(false);

    }

    public void Fechar(){
        this.painel.SetActive(false);
    }
}
