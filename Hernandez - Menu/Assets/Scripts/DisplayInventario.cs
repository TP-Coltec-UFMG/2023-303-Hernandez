using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventario : MonoBehaviour
{
    private void OnMouseOver() {
        Debug.Log("oi");
        while(this.transform.position.y < -194)
        {
            this.transform.position = new Vector3(this.transform.position.x, -194, this.transform.position.z);
        }
    }

    private void OnMouseExit() 
    {
        while(this.transform.position.y < 194)
        {
            this.transform.position = new Vector3(this.transform.position.x, -255, this.transform.position.z);
        }
    }
}