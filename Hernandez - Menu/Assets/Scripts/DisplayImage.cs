using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayImage : MonoBehaviour
{
    [SerializeField] private int currentWall;
    [SerializeField] private Camera mainCamera;
    private SpriteRenderer sprite;

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
        this.fourDigits.SetActive(false);
        //18 * currentWall
    }

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
}
