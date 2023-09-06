using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    [SerializeField] private GameObject painel;
    public void AbreMenu(){
        this.painel.SetActive(true);
    }

    public void FechaMenu(){
        this.painel.SetActive(false);
    }

    public void Reiniciar(){
        SceneManager.LoadScene("Menu");
    }

    public void Sair(){
        Application.Quit();
    }
}
