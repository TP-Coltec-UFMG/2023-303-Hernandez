using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventario : MonoBehaviour , IDragHandler , IEndDragHandler
{
    private Vector3 startingPoint;
    [SerializeField] GameObject useText;
    private void Start() {
        startingPoint = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
    public void OnDrag(PointerEventData eventData) 
    {
        this.transform.position = Input.mousePosition;
        if  ((95 < this.transform.localPosition.y) && (this.transform.localPosition.y < 215) && (150 < this.transform.localPosition.x) && (this.transform.localPosition.x < 290))
        {
            useText.SetActive(true);
        }
        if (!((95 < this.transform.localPosition.y) && (this.transform.localPosition.y < 215) && (150 < this.transform.localPosition.x) && (this.transform.localPosition.x < 290)))
        {
            useText.SetActive(false);
        }
    }
    public void OnEndDrag (PointerEventData eventData) 
    {
        if(false) {
        }
        else
        {
            this.transform.position = startingPoint;
            useText.SetActive(false);
        }
    }
}
