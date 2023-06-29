using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventario : MonoBehaviour
{
    [SerializeField] Inventario item;
    public void OnMouseOver() 
    {
        if(item.activeDrag)
        {
            item.DisplayText(true);
        }
    }
    private void OnMouseExit()
    {
        item.DisplayText(false);
    }


    
}