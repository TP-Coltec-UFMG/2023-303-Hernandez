using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayItemtext : MonoBehaviour
{
    [SerializeField] Inventario item;
    [SerializeField] Inventario itemFalso;
    public void OnMouseOver() 
    {
        if(item.activeDrag)
        {
            item.DisplayText(true);
            Debug.Log("correto");
            item.onTop = true;
        }
        else if(itemFalso.activeDrag)
        {
            itemFalso.DisplayText(true);
            Debug.Log("errado");
        }

        if((!item.activeDrag)&&(!itemFalso.activeDrag))
        {
            item.onTop = false;
            item.DisplayText(false);
            itemFalso.DisplayText(false);
        }
    }
    private void OnMouseExit()
    {
        item.onTop = false;
        item.DisplayText(false);
        itemFalso.DisplayText(false);
    }

}

