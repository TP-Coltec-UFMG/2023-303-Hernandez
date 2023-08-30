using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayImage : MonoBehaviour
{
    static int currentWall = 0;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject quadroMC;
    private SpriteRenderer sprite;

    [SerializeField] private GameObject parede1;
    [SerializeField] private GameObject parede2;
    [SerializeField] private GameObject parede3;
    [SerializeField] private GameObject parede4;
    [SerializeField] private GameObject botaoDir;
    [SerializeField] private GameObject botaoEsq;

    [SerializeField] private GameObject fourDigits;
    [SerializeField] private GameObject photoFind;
    [SerializeField] private GameObject buttonPhotoFind;
    [SerializeField] private GameObject lightPanel;
    [SerializeField] private GameObject lightPanel2;
    [SerializeField] private GameObject lightPanelBase;
    [SerializeField] private GameObject lightPanelButton;
    [SerializeField] private GameObject puzzle8;
    [SerializeField] private GameObject puzzle8base;
    [SerializeField] private GameObject buttonTV;
    [SerializeField] private GameObject TV;
    [SerializeField] private GameObject closeTV;
    [SerializeField] private GameObject painelTV;


    [SerializeField] private Puzzle8 the_puzzle;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        if(currentWall == 1) {
            currentWall--;
            changeWall(true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            changeWall(true);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            changeWall(false);
        }

        if(the_puzzle.Confere() == true)
        {
            this.quadroMC.transform.position = new Vector3(47.15f, 3.17f);
            this.lightPanelBase.SetActive(true);
            this.puzzle8base.SetActive(false);
        }
    }

    public void changeWall(bool dir)
    {

        if (dir) currentWall++;
        else currentWall--;

        if (currentWall > 3) currentWall = 0;
        else if (currentWall < 0) currentWall = 3;
        mainCamera.transform.position = new Vector3(18 * currentWall, mainCamera.transform.position.y, mainCamera.transform.position.z);

        switch (currentWall)
        {
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


    //Desabilitar Puzzles ///
    public void TurnOnTV()
    {
        this.buttonTV.SetActive(false);
        this.TV.SetActive(false);
        this.closeTV.SetActive(true);
        this.painelTV.SetActive(true);
    }

    public void TurnOffTV()
    {
        this.buttonTV.SetActive(true);
        this.TV.SetActive(true);
        this.closeTV.SetActive(false);
        this.painelTV.SetActive(false);
    }
    public void TurnOnDigit4()
    {
        this.fourDigits.SetActive(true);
    }

    public void TurnOffDigit4()
    {
        this.fourDigits.SetActive(false);
    }

    public void TurnOnPhotoFind()
    {
        this.photoFind.SetActive(true);
        this.buttonPhotoFind.SetActive(false);
        this.puzzle8base.SetActive(false);
        this.lightPanelBase.SetActive(false);
        this.botaoDir.SetActive(false);
        this.botaoEsq.SetActive(false);
        this.lightPanel.SetActive(false);
        this.lightPanel2.SetActive(false);
        this.lightPanelButton.SetActive(false);
    }

    public void TurnOffPhotoFind()
    {
        this.photoFind.SetActive(false);
        this.buttonPhotoFind.SetActive(true);
        this.puzzle8base.SetActive(true);
        this.botaoDir.SetActive(true);
        this.botaoEsq.SetActive(true);
        this.lightPanelBase.SetActive(true);
        this.lightPanelButton.SetActive(true);
    }

    public void TurnOnLightPanel()
    {
        this.lightPanel.SetActive(true);
        this.lightPanel2.SetActive(true);
    }

    public void TurnOffLightPanel()
    {
        this.lightPanel.SetActive(false);
        this.lightPanel2.SetActive(false);
    }

    public void TurnOn8Puzzle(){
        this.puzzle8.SetActive(true);
    }

    public void TurnOff8Puzzle(){
        this.puzzle8.SetActive(false);
    }

    public void ComputerScene()
    {
        SceneManager.LoadScene("Computer");
    }



    //Desabilitar paredes
    private void DisableWall1()
    {
        this.TurnOffDigit4();
        this.parede1.SetActive(false);
    }

    private void DisableWall2()
    {
        ;
        this.parede2.SetActive(false);
    }

    private void DisableWall3()
    {
        this.parede3.SetActive(false);
    }

    private void DisableWall4()
    {
        this.TurnOffPhotoFind();
        this.parede4.SetActive(false);
        this.buttonPhotoFind.SetActive(false);
    }

    //Habilitar paredes
    private void EnableWall1()
    {
        this.DisableWall2();
        this.DisableWall3();
        this.DisableWall4();
        this.parede1.SetActive(true);
    }

    private void EnableWall2()
    {
        this.DisableWall1();
        this.DisableWall3();
        this.DisableWall4();
        this.parede2.SetActive(true);
    }

    private void EnableWall3()
    {
        this.DisableWall1();
        this.DisableWall2();
        this.DisableWall4();
        this.parede3.SetActive(true);
    }

    private void EnableWall4()
    {
        this.DisableWall1();
        this.DisableWall2();
        this.DisableWall3();
        this.parede4.SetActive(true);
        this.buttonPhotoFind.SetActive(true);
    }
}