using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour
{
    Vector3 startPoint;
    [SerializeField] SpriteRenderer wireEnd;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag(){
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;
        this.transform.position = newPosition;

        Vector3 direction = startPoint - newPosition;
        this.transform.right = direction;

        float dist = Vector2.Distance(newPosition, startPoint);
        wireEnd.size = new Vector2(dist, wireEnd.size.y);
    }
}
