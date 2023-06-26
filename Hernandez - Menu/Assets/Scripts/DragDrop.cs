using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour , IDragHandler {public void OnDrag(PointerEventData eventData) {this.transform.position = Input.mousePosition;}}
