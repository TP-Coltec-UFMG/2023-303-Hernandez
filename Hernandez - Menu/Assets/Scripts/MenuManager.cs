using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject ajustes;
    [SerializeField] private GameObject creditos;
    [SerializeField] private GameObject menuPrincipal;

    public void AbrirAjustes(){
        menuPrincipal.SetActive(false);
        ajustes.SetActive(true);
    }

    public void FecharAjustes(){
        menuPrincipal.SetActive(true);
        ajustes.SetActive(false);
    }

    public void AbrirCreditos(){
        menuPrincipal.SetActive(false);
        creditos.SetActive(true);
    }

    public void FecharCreditos(){
        menuPrincipal.SetActive(true);
        creditos.SetActive(false);
    }

    public void Jogar(){
        SceneManager.LoadScene("Secreto");
    }

    public void Sair(){
        Application.Quit();
    }

}
