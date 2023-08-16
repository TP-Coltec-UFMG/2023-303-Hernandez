using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour
{
    Vector3 startPoint;
    Vector3 startPosition;
    [SerializeField] SpriteRenderer wireEnd;
    private bool taCerto = false;
    private int fiosCertos = 0;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag(){
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;
        
        //Pega todos os colisores ao redor
        Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, .2f);

        foreach(Collider2D collider in colliders){
            //Verifica se não é o próprio colisor
            if(collider.gameObject.tag == "Wire"){
                this.taCerto = true;
                if(collider.gameObject != this.gameObject){
                    UpdateWire(collider.transform.position);

                    if(collider.transform.parent.name.Equals(this.transform.parent.name))
                    {

                    } 
                    


                    //retorna para impedir que o outro UpdateWire ocorra
                    return;
                }
            }
        }
        
        this.taCerto = false;
        UpdateWire(newPosition);
    }

    void OnCollisionEnter(Collision collision){
        if(collision.transform.parent.name.Equals(this.transform.parent.name)){
            fiosCertos++;
            Debug.Log(fiosCertos);
        }
    }

    void OnCollisionExit(Collision collision){
        if(collision.transform.parent.name.Equals(this.transform.parent.name)){
            fiosCertos--;
            Debug.Log(fiosCertos);
        }
    }


    private void OnMouseUp(){

        if(!taCerto){
            UpdateWire(startPosition);
        }


    }

    void UpdateWire(Vector3 newPosition){
        this.transform.position = newPosition;

        Vector3 direction = newPosition - startPoint;
        this.transform.right = direction * transform.lossyScale.x;

        float dist = Vector2.Distance(startPoint, newPosition);
        wireEnd.size = new Vector2((dist+0.1f), wireEnd.size.y);
    }
}
