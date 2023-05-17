using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject ajustes;
    [SerializeField] private GameObject menuPrincipal;

    public void AbrirAjustes(){
        menuPrincipal.SetActive(false);
        ajustes.SetActive(true);
    }

    public void FecharAjustes(){
        menuPrincipal.SetActive(true);
        ajustes.SetActive(false);
    }

    public void Sair(){
        Application.Quit();
    }

}
