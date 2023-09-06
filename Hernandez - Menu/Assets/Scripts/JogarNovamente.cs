using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JogarNovamente : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioSource audio;
    public void CallJogarNovamente()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExcluirTodoTipoDeSomExistente()
    {
        this.audio.Stop();
    }
}
