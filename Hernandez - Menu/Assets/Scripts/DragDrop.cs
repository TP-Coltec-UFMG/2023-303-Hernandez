using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour , IDragHandler , IEndDragHandler
{
    public void OnDrag(PointerEventData eventData) 
    {
        this.transform.position = Input.mousePosition;
    }
    public void OnEndDrag (PointerEventData eventData) 
    {
        if  ((530 < this.transform.localPosition.y) && (this.transform.localPosition.y < 750) && (-530 < this.transform.localPosition.x) && (this.transform.localPosition.x < -320))
        {
            this.transform.localPosition = new Vector3(-420, 635, this.transform.localPosition.z);
        }
        else if  ((530 < this.transform.localPosition.y) && (this.transform.localPosition.y < 750) && (-110 < this.transform.localPosition.x) && (this.transform.localPosition.x < 110))
        {
            this.transform.localPosition = new Vector3(0, 635, this.transform.localPosition.z);
        }
        else if  ((530 < this.transform.localPosition.y) && (this.transform.localPosition.y < 750) && (315 < this.transform.localPosition.x) && (this.transform.localPosition.x < 535))
        {
            this.transform.localPosition = new Vector3(425, 635, this.transform.localPosition.z);
        }
        else if  ((200 < this.transform.localPosition.y) && (this.transform.localPosition.y < 420) && (-530 < this.transform.localPosition.x) && (this.transform.localPosition.x < -320))
        {
            this.transform.localPosition = new Vector3(-420, 310, this.transform.localPosition.z);
        }
        else if  ((200 < this.transform.localPosition.y) && (this.transform.localPosition.y < 420) && (-110 < this.transform.localPosition.x) && (this.transform.localPosition.x < 110))
        {
            this.transform.localPosition = new Vector3(0, 310, this.transform.localPosition.z);
        }
        else if  ((200 < this.transform.localPosition.y) && (this.transform.localPosition.y < 420) && (315 < this.transform.localPosition.x) && (this.transform.localPosition.x < 535))
        {
            this.transform.localPosition = new Vector3(425, 310, this.transform.localPosition.z);
        }
    }
}
