using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Almofada : MonoBehaviour
{
    [SerializeField] private GameObject fusivel;
    [SerializeField] private GameObject fuseInv;
    private bool aindaExiste = true;
    private bool clicado = false;

    public void MoveAlmofada(){
        if(!clicado) {
            if(aindaExiste) fusivel.SetActive(true);
            this.transform.position = new Vector2(this.transform.position.x + 80, this.transform.position.y);
            this.clicado = true;
        }
        else{
            fusivel.SetActive(false);
            this.transform.position = new Vector2(this.transform.position.x - 80, this.transform.position.y);
            this.clicado = false;
        }
    }

    public void PegaFusivel(){
        this.aindaExiste = false;
        fusivel.SetActive(false);
        fuseInv.SetActive(true);
    }
}
