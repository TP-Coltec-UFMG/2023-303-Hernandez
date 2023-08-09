using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject butao;
    [SerializeField] private GameObject joguinho;
    [SerializeField] private GameObject icon;

    public void OpenPuzzle()
    {
        butao.SetActive(true);
        joguinho.SetActive(true);
        icon.SetActive(false);
    }

    public void ClosePuzzle()
    {
        butao.SetActive(false);
        joguinho.SetActive(false);
        icon.SetActive(true);
    }

    public void SecretoScene()
    {
        SceneManager.LoadScene("Secreto");
    }
    
}
