using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoComputador : MonoBehaviour
{
    [SerializeField] private GameObject painel;
    [SerializeField] private GameObject resposta;
    [SerializeField] private GameObject block;
    private bool ativo = false;

    public void AbreBloco(){
        if(!ativo){
            this.painel.SetActive(true);
            this.ativo = true;
        }
    }

    public void FechaBloco(){
        if(ativo){
            this.painel.SetActive(false);
            this.ativo = false;
        }
    }

    public void VerificaSenha(string senha){
        if(senha == "A Noite Estrelada"){
            this.resposta.SetActive(true);
            this.block.SetActive(false);
        }
    }
}
