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

    [SerializeField] private int itemNumber;
    public bool activeDrag = false;

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
        if (activeDrag)
        {
            switch (itemNumber)
            {
                case 5:
                    this.inventarioBase.SetActive(false);
                    this.leCanvas.SetActive(false);
                    this.gameOver.SetActive(true);
                    break;
            }

            this.transform.position = startingPoint;
            useText.SetActive(false);

        }
        activeDrag = false;
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
