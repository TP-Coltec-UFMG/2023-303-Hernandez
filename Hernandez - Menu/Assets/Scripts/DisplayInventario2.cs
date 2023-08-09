using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventario2 : MonoBehaviour
{
    private bool estaAparecendo = true;
    [SerializeField] GameObject inventario;
    [SerializeField] GameObject butao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApareceInventario(){


        if(estaAparecendo){
            // while(inventario.GetComponent<RectTransform>().anchoredPosition.y > -56){
            //     inventario.transform.position = Vector2.MoveTowards(inventario.transform.position, new Vector2(0, -56), 2.0f * Time.deltaTime);
            
            this.StartCoroutine(SmoothMove(new Vector3(inventario.transform.position.x, inventario.transform.position.y - (Screen.height / 8), 0), 0.1f));
            estaAparecendo = false;

        } else{
            this.StartCoroutine(SmoothMove(new Vector3(inventario.transform.position.x, inventario.transform.position.y + (Screen.height / 8), 0), 0.1f));
            estaAparecendo = true;

        }
    }

    IEnumerator SmoothMove(Vector3 target, float delta)
	{
        this.butao.SetActive(false);
		// Will need to perform some of this process and yield until next frames
		float closeEnough = 0.2f;
		float distance = (inventario.transform.position - target).magnitude;

		// GC will trigger unless we define this ahead of time
		WaitForEndOfFrame wait = new WaitForEndOfFrame();

		// Continue until we're there
		while(distance >= closeEnough)
		{
			// Confirm that it's moving
			Debug.Log("Executing Movement");

			// Move a bit then  wait until next  frame
			inventario.transform.position = Vector3.Lerp(inventario.transform.position, target, delta);
			yield return wait;

			// Check if we should repeat
			distance = (inventario.transform.position - target).magnitude;
		}

		// Complete the motion to prevent negligible sliding
		inventario.transform.position = target;

		// Confirm  it's ended
		Debug.Log ("Movement Complete");
        this.butao.SetActive(true);
	}
}