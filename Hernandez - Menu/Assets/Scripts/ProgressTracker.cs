using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    //cada progresso do jogo será salvo em uma posição diferente do array, dessa forma, é possível verificar quais puzzles já foram solucionados
    //para chamar a função StoryProgress serão utilizados ACTIONS
    //EU VOU CORINGAR HAHAHAHAHAHAHAHHAHAHA

    [SerializeField] bool[] progress = new bool[10];


    private void OnEnable(){
        Actions.OnStoryAdvanced += StoryProgress;
    }

    
    private void OnDisable(){
        Actions.OnStoryAdvanced -= StoryProgress;
    }


    public void StoryProgress(int progressNum){

        this.progress[progressNum] = true;

    }

}
