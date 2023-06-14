using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{
    [SerializeField] private int currentWall;
    [SerializeField] private Camera mainCamera;
    private SpriteRenderer sprite;

    private void Start() {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void changeWall(bool dir){

        if (dir) currentWall++;
        else currentWall--;

        if (currentWall > 3) currentWall = 1;
        else if (currentWall < 1) currentWall = 3;
        mainCamera.transform.position = new Vector3(18 * (currentWall - 1), mainCamera.transform.position.y, mainCamera.transform.position.z);
        //18 * currentWall
    }
}
