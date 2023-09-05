using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventario : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private Vector3 startingPoint;
    [SerializeField] private GameObject useText;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject inventarioBase;
    [SerializeField] private GameObject leCanvas;
    [SerializeField] private GameObject luzNegra;
    [SerializeField] private GameObject canalCerto;
    [SerializeField] private GameObject tvCrack;
    [SerializeField] private GameObject tvChanels;
    [SerializeField] private GameObject UVCollider;
    [SerializeField] private GameObject restart;
    [SerializeField] GameObject tvNiverButton;
    [SerializeField] private int itemNumber;
    public bool activeDrag = false;
    public bool onTop = false;
    public bool luzTaLigada = false;

    private void Start()
    {
        startingPoint = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
        activeDrag = true;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        activeDrag = false;
        UnityEngine.Debug.Log(onTop);
        if (onTop){
            switch (itemNumber)
            {
                case 2:
                this.tvCrack.SetActive(true);
                this.canalCerto.SetActive(false);
                this.tvNiverButton.SetActive(false);
                this.tvChanels.SetActive(false);
                this.UVCollider.SetActive(true);
                Actions.OnStoryAdvanced(4);
                break;

                case 3:
                    this.luzNegra.SetActive(true);
                    this.gameObject.SetActive(false);
                    this.luzTaLigada = true;
                    Actions.OnStoryAdvanced(5);
                break;

                case 5:
                    this.inventarioBase.SetActive(false);
                    this.leCanvas.SetActive(false);
                    this.gameOver.SetActive(true);
                    this.restart.SetActive(true);

                break;
            }

        }
        this.transform.position = startingPoint;
    }

    public void DisplayText(bool active)
    {
        if (active)
        {
            activeDrag = active;
            useText.SetActive(true);
        }
        else
        {
            useText.SetActive(false);
        }
    }


}
