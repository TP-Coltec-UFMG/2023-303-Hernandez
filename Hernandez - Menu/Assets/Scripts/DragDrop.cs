using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour , IDragHandler , IEndDragHandler
{
    private Vector3 startingPoint;
    private void Start() {
        startingPoint = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
    public void OnDrag(PointerEventData eventData) 
    {
        this.transform.position = Input.mousePosition;
    }
    public void OnEndDrag (PointerEventData eventData) 
    {
        if  ((-269 < this.transform.localPosition.y) && (this.transform.localPosition.y < 489) && (-693 < this.transform.localPosition.x) && (this.transform.localPosition.x < -473))
        {
            this.transform.localPosition = new Vector3(-583, 379, this.transform.localPosition.z);
        }
        else if  ((210 < this.transform.localPosition.y) && (this.transform.localPosition.y < 430) && (-103 < this.transform.localPosition.x) && (this.transform.localPosition.x < 117))
        {
            this.transform.localPosition = new Vector3(7, 320, this.transform.localPosition.z);
        }
        else if  ((270 < this.transform.localPosition.y) && (this.transform.localPosition.y < 490) && (532 < this.transform.localPosition.x) && (this.transform.localPosition.x < 752))
        {
            this.transform.localPosition = new Vector3(642, 380, this.transform.localPosition.z);
        }
        else if  ((-549 < this.transform.localPosition.y) && (this.transform.localPosition.y < -329) && (-713 < this.transform.localPosition.x) && (this.transform.localPosition.x < -493))
        {
            this.transform.localPosition = new Vector3(-603, -439, this.transform.localPosition.z);
        }
        else if  ((-602 < this.transform.localPosition.y) && (this.transform.localPosition.y < 382) && (-117 < this.transform.localPosition.x) && (this.transform.localPosition.x < 103))
        {
            this.transform.localPosition = new Vector3(-7, -492, this.transform.localPosition.z);
        }
        else if  ((-549 < this.transform.localPosition.y) && (this.transform.localPosition.y < -329) && (507 < this.transform.localPosition.x) && (this.transform.localPosition.x < 727))
        {
            this.transform.localPosition = new Vector3(617, -439, this.transform.localPosition.z);
        }
        else
        {
            this.transform.position = startingPoint;
        }
    }
}
