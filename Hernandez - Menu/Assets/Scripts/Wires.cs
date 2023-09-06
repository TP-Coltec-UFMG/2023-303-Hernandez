using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour
{
    static int fiosCertos = 0;
    static bool jaVerificou = false;
    Vector3 startPoint;
    Vector3 startPosition;
    [SerializeField] SpriteRenderer wireEnd;
    private bool taCerto = false;
    [SerializeField] LightPanel lightPanel;


    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
        startPosition = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if(fiosCertos == 4){
            //Se o jogador acertou as todos os fios: espera 0.5 segundos e destroi o script
            Debug.Log("FUNCIONOU!");
            Invoke("Destruir", 0.5f );
        } else{
            CancelInvoke("Destruir");
        }
    }

    private void Destruir(){
        //ultimos suspiros do script
        if(!jaVerificou){
            this.lightPanel.verifica++;
            jaVerificou = true;
        }

        Debug.Log(lightPanel.verifica);
        this.GetComponent<Wires>().enabled = false;
    }

    private void OnMouseDrag(){
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;
        
        //Pega todos os colisores ao redor
        Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, .2f);

        foreach(Collider2D collider in colliders){

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
            this.taCerto = false;
            UpdateWire(newPosition);
        }

    }

    void OnTriggerEnter2D(Collider2D collider){

        if(collider.gameObject.transform.parent.name.Equals(this.transform.parent.name)){
            fiosCertos++;

        }
    }

    void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.transform.parent.name.Equals(this.transform.parent.name)){
            fiosCertos--;
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

        float dist = Vector2.Distance(newPosition, startPoint);
        wireEnd.size = new Vector2((dist), wireEnd.size.y);
    }

}
