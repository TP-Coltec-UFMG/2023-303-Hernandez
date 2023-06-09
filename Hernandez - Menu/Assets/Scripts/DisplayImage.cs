using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayImage : MonoBehaviour
{
    [SerializeField] private int currentWall;
    [SerializeField] private Camera mainCamera;
    private SpriteRenderer sprite;

    [SerializeField] private GameObject parede1;
    [SerializeField] private GameObject parede2;
    [SerializeField] private GameObject parede3;
    [SerializeField] private GameObject parede4;

    [SerializeField] private GameObject fourDigits;
    [SerializeField] private GameObject photoFind;
    [SerializeField] private GameObject buttonPhotoFind;

    private void Start() {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void changeWall(bool dir){

        if (dir) currentWall++;
        else currentWall--;

        if (currentWall > 3) currentWall = 0;
        else if (currentWall < 0) currentWall = 3;
        mainCamera.transform.position = new Vector3(18 * currentWall, mainCamera.transform.position.y, mainCamera.transform.position.z);

        switch (currentWall) {
            case 0:
                this.EnableWall1();
                break;
            case 1:
                this.EnableWall2();
                break;
            case 2:
                this.EnableWall3();
                break;
            case 3:
                this.EnableWall4();
                break;
        }

    }


    //Desabilitar Puzzles
    public void TurnOnDigit4(){
        this.fourDigits.SetActive(true);
    }

    public void TurnOffDigit4(){
        this.fourDigits.SetActive(false);
    }

    public void TurnOnPhotoFind(){
        this.photoFind.SetActive(true);
        this.buttonPhotoFind.SetActive(false);
    }

    public void TurnOffPhotoFind(){
        this.photoFind.SetActive(false);
        this.buttonPhotoFind.SetActive(true);
    }


    //Desabilitar paredes
    private void DisableWall1(){
        this.TurnOffDigit4();
        this.parede1.SetActive(false);
    }

    private void DisableWall2(){;
        this.parede2.SetActive(false);
    }

    private void DisableWall3(){
        this.parede3.SetActive(false);
    }

    private void DisableWall4(){
        this.TurnOffPhotoFind();
        this.parede4.SetActive(false);
        this.buttonPhotoFind.SetActive(false);
    }

    //Habilitar paredes
    private void EnableWall1(){
        this.DisableWall2();
        this.DisableWall3();
        this.DisableWall4();
        this.parede1.SetActive(true);
    }

    private void EnableWall2(){
        this.DisableWall1();
        this.DisableWall3();
        this.DisableWall4();
        this.parede2.SetActive(true);
    }

    private void EnableWall3(){
        this.DisableWall1();
        this.DisableWall2();
        this.DisableWall4();
        this.parede3.SetActive(true);
    }

    private void EnableWall4(){
        this.DisableWall1();
        this.DisableWall2();
        this.DisableWall3();
        this.parede4.SetActive(true);
        this.buttonPhotoFind.SetActive(true);
    }
}