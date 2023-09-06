using System.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayImage : MonoBehaviour
{
    private int currentWall = 0;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject quadroMC;
    private SpriteRenderer sprite;
    private bool ModoAjudaOn = false;

    private bool MenuPauseOn = false;

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
    [SerializeField] private GameObject TV;
    [SerializeField] private GameObject closeTV;
    [SerializeField] private GameObject painelTV;
    [SerializeField] private GameObject computador;
    [SerializeField] private GameObject HUD;
    [SerializeField] private Inventario Inventario;
    [SerializeField] private GameObject postit;
    [SerializeField] private GameObject inversePostit;
    [SerializeField] private GameObject closePostit;
    [SerializeField] private GameObject luzNaTV;
    [SerializeField] private GameObject luzUV;
    [SerializeField] private GameObject luzCollider;
    [SerializeField] private Puzzle8 the_puzzle;
    [SerializeField] private GameObject niverTVBase;
    [SerializeField] private GameObject closeNiverTVBase;
    [SerializeField] private GameObject garfoBase;
    [SerializeField] private GameObject garfoSprite;
    [SerializeField] private GameObject garfoInventario;
    [SerializeField] private GameObject garfoOpen;
    [SerializeField] private GameObject almofada;
    [SerializeField] private GameObject ModoAjuda;
    [SerializeField] private GameObject botoesP1;
    [SerializeField] private GameObject botoesP3;
    [SerializeField] private GameObject quadro;
    [SerializeField] private GameObject luzVerd;
    [SerializeField] private GameObject luzVerm;
    [SerializeField] private MouseControl mouseControl;
    [SerializeField] private GameObject panelCadeado;
    [SerializeField] private GameObject panelDiario;



    private bool ehComputador = false;

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
        if (Input.GetKeyDown(KeyCode.RightArrow) && !ehComputador)
        {
            changeWall(true);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && !ehComputador)
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
       StartCoroutine(fadeWallChanger(0.095f, dir));
    }

    IEnumerator fadeWallChanger(float timeWait, bool dir)
    {
        yield return new WaitForSeconds(timeWait);
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

    public void TurnOnQuadro(){


        this.quadro.SetActive(true);
        this.botoesP3.SetActive(false);
        
    }

    public void TurnOffQuadro(){

        this.quadro.SetActive(false);
        this.botoesP3.SetActive(true);
        
    }

    public void TurnOnOffModoAjuda(){

        if(!ModoAjudaOn){
                this.ModoAjuda.SetActive(true);
                this.parede1.SetActive(false);
                this.parede2.SetActive(false);
                this.botoesP3.SetActive(false);
                this.parede4.SetActive(false);
                this.botaoDir.SetActive(false);
                this.botaoEsq.SetActive(false);
                this.ModoAjudaOn = true;
        } else{
            this.ModoAjuda.SetActive(false);
            this.botoesP3.SetActive(true);
            this.botaoDir.SetActive(true);
            this.botaoEsq.SetActive(true);
            this.ModoAjudaOn = false;

            switch(currentWall){
                case 0:
                    this.parede1.SetActive(true);
                    break;
                case 1:
                    this.parede2.SetActive(true);
                    break;
                case 2:
                    this.parede3.SetActive(true);
                    break;
                case 3:
                    this.parede4.SetActive(true);
                    break;
            }
        }
    }

    public void MenuPause(){
        if(!MenuPauseOn){
            MenuPauseOn = !MenuPauseOn;
            DisableWall1();
            DisableWall2();
            DisableWall3();
            DisableWall4();
        } else{
            MenuPauseOn = !MenuPauseOn;
            switch(currentWall){
                case 0:
                    this.parede1.SetActive(true);
                    break;
                case 1:
                    this.parede2.SetActive(true);
                    break;
                case 2:
                    this.parede3.SetActive(true);
                    break;
                case 3:
                    this.parede4.SetActive(true);
                    break;
            }
        }
    }

    
    public void TurnOnDiario()
    {
        this.panelDiario.SetActive(true);
    }

    public void TurnOffDiario()
    {
        this.panelDiario.SetActive(false);
    }


    public void TurnOnTV()
    {
        this.botoesP1.SetActive(false);
        this.TV.SetActive(false);
        this.closeTV.SetActive(true);
        this.painelTV.SetActive(true);
    }

    public void TurnOffTV()
    {
        this.botoesP1.SetActive(true);
        this.TV.SetActive(true);
        this.closeTV.SetActive(false);
        this.painelTV.SetActive(false);
    }

    public void TurnOnPostits(){

        if(!this.Inventario.luzTaLigada){
            this.postit.SetActive(true);
        } else{
            this.inversePostit.SetActive(true);
        }

        this.closePostit.SetActive(true);
    }

    public void TurnOffPostits(){
        this.postit.SetActive(false);
        this.inversePostit.SetActive(false);
        this.closePostit.SetActive(false);

    }

    public void TurnOnPanelCadeado(){
        this.panelCadeado.SetActive(true); 
    }

    public void TurnOffPanelCadeado(){
        this.panelCadeado.SetActive(false); 
    }

    public void TurnOnNiver()
    {
        this.niverTVBase.SetActive(true);
        this.closeNiverTVBase.SetActive(true);
    }

    public void TurnOffNiver()
    {
        this.niverTVBase.SetActive(false);
        this.closeNiverTVBase.SetActive(false);
    }

    public void TurnOnGarfo()
    {
        this.garfoBase.SetActive(true);
        this.botoesP3.SetActive(false);
        this.garfoOpen.SetActive(false);
    }

    public void TurnOffGarfo()
    {
        this.garfoBase.SetActive(false);
        this.botoesP3.SetActive(true);
        this.garfoOpen.SetActive(true);
    }

    public void GetGarfo()
    {
        this.garfoBase.SetActive(false);
        this.botoesP3.SetActive(true);
        this.garfoInventario.SetActive(true);
        this.garfoSprite.SetActive(false);
        this.garfoOpen.SetActive(false);
    }


    public void TurnOnDigit4()
    {
        this.fourDigits.SetActive(true);
        this.botoesP1.SetActive(false);
    }

    public void TurnOffDigit4()
    {
        this.fourDigits.SetActive(false);
        this.botoesP1.SetActive(true);
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
        this.luzVerd.SetActive(false);
        this.luzVerm.SetActive(false);
    }
    public void TurnOffLightPanel()
    {
        this.lightPanel.SetActive(false);
        this.lightPanel2.SetActive(false);
        this.luzVerd.SetActive(true);
        this.luzVerm.SetActive(true);
    }

    public void TurnOn8Puzzle(){
        this.puzzle8.SetActive(true);
    }

    public void TurnOff8Puzzle(){
        this.puzzle8.SetActive(false);
    }

    public void GetUVLight(){
        this.luzNaTV.SetActive(false);
        this.luzUV.SetActive(true);
        this.luzCollider.SetActive(false);
    }

    public void ComputerScene()
    {
        this.HUD.SetActive(false);
        this.computador.SetActive(true);
        this.ehComputador = true;
        mouseControl.OnButtonCursorEnterComputer();
        DisableWall2();
        mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, 11, mainCamera.transform.position.z);
    }

    public void RoomScene(){
        this.HUD.SetActive(true);
        this.computador.SetActive(false);
        this.ehComputador = false;
        mouseControl.OnButtonCursorEnter();
        EnableWall2();
        mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, 0, mainCamera.transform.position.z);
    }

    //Desabilitar paredes
    public void DisableWall1()
    {
        this.TurnOffDigit4();
        this.parede1.SetActive(false);
    }

    private void DisableWall2()
    {
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
    public void EnableWall1()
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