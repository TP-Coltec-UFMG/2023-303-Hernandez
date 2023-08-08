using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventario : MonoBehaviour , IDragHandler , IEndDragHandler
{
    private Vector3 startingPoint;
    [SerializeField] GameObject useText;
    public bool activeDrag = false;

    private void Start() {
        startingPoint = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
    public void OnDrag(PointerEventData eventData) 
    {
        this.transform.position = Input.mousePosition;
        activeDrag = true;
    }
    public void OnEndDrag (PointerEventData eventData) 
    {
        activeDrag = false;
        if(false) {
        }
        else
        {
            this.transform.position = startingPoint;
            useText.SetActive(false);
        }
    }

    public void DisplayText (bool active) 
    {
        if(active)
        {
            useText.SetActive(true);
        }
        else
        {
            useText.SetActive(false);
        }
    }

    
}
