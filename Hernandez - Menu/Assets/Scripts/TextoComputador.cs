using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextoComputador : MonoBehaviour
{
    [SerializeField] private GameObject painel;
    [SerializeField] private GameObject resposta;
    [SerializeField] private GameObject block;
    [SerializeField] private GameObject areaDeTrabalho;
    [SerializeField] private GameObject telaDeBloqueio;
    [SerializeField] private TMP_InputField inputSenBloqueio;
    private bool ativo = false;
    private bool ehSenha = true;

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

    public void VerificaSenhaUser(string senha){
        if(senha == "1234"){
            this.areaDeTrabalho.SetActive(true);
            this.telaDeBloqueio.SetActive(false);
        }
    }

    public void MudaTipoTexto(){
        if(ehSenha){
            this.inputSenBloqueio.contentType = TMP_InputField.ContentType.Standard;
            ehSenha = !ehSenha;
        } 
        else {
            this.inputSenBloqueio.contentType = TMP_InputField.ContentType.Password;
            ehSenha = !ehSenha;
        }
        inputSenBloqueio.Select();
    }
}
