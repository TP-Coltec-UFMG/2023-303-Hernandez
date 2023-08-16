using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour
{
    Vector3 startPoint;
    Vector3 startPosition;
    [SerializeField] SpriteRenderer wireEnd;
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
            if(collider.gameObject != this.gameObject){
            UpdateWire(collider.transform.position);
            //retorna para impedir que o outro UpdateWire ocorra
            return;
            }
        }

        

        UpdateWire(newPosition);
    }

    private void OnMouseUp(){
        UpdateWire(startPosition);

    }

    void UpdateWire(Vector3 newPosition){
        this.transform.position = newPosition;

        Vector3 direction = newPosition - startPoint;
        this.transform.right = direction * transform.lossyScale.x;

        float dist = Vector2.Distance(startPoint, newPosition);
        wireEnd.size = new Vector2((dist+0.1f), wireEnd.size.y);
    }
}
