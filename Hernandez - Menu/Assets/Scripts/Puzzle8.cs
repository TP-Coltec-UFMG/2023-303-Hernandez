using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle8 : MonoBehaviour
{

    private int[] positions = new int[] {8, 9, 5, 7, 1, 6, 3, 2, 4};
    private int[] reference = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
    private int iBlank = 6;

    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button4;
    [SerializeField] private GameObject button5;
    [SerializeField] private GameObject button6;
    [SerializeField] private GameObject button7;
    [SerializeField] private GameObject button8;
    [SerializeField] private GameObject button9;

    void Update()
    {
        
        if (confere()){} //ativa alguma coisa
    }

    public void movePiece(int piece){
        int iPiece = findInArray(piece);

        if (canMove(iPiece)){
            int swp = iPiece;
            iPiece = iBlank;
            iBlank = swp;
        }

        if(piece == 1) button1.transform.localPosition = blankPos();
        else if(piece == 2) button2.transform.localPosition = blankPos();
        else if(piece == 4) button4.transform.localPosition = blankPos();
        else if(piece == 5) button5.transform.localPosition = blankPos();
        else if(piece == 6) button6.transform.localPosition = blankPos();
        else if(piece == 7) button7.transform.localPosition = blankPos();
        else if(piece == 8) button8.transform.localPosition = blankPos();
        else if(piece == 9) button9.transform.localPosition = blankPos();

    }

    private bool confere(){
        for(int i = 0; i < 9; i++){
            if(!(positions[i] == reference[i])) return false;
        }
        return true;
    }

    private int findInArray(int piece){
        for (int i = 0; i < 9; i++){
            if (positions[i] == piece) return i;
        }
        return -1;
    }

    private bool canMove(int iPiece){
        if((iBlank == 0) && (iPiece == 1 || iPiece == 3)) return true;
        else if((iBlank == 1) && (iPiece == 0 || iPiece == 2 || iPiece == 4)) return true;
        else if((iBlank == 2) && (iPiece == 1 || iPiece == 5)) return true;
        else if((iBlank == 3) && (iPiece == 0 || iPiece == 4 || iPiece == 6)) return true;
        else if((iBlank == 4) && (iPiece == 1 || iPiece == 3 || iPiece == 5 || iPiece == 7)) return true;
        else if((iBlank == 5) && (iPiece == 2 || iPiece == 4 || iPiece == 8)) return true;
        else if((iBlank == 6) && (iPiece == 3 || iPiece == 7)) return true;
        else if((iBlank == 7) && (iPiece == 6 || iPiece == 4 || iPiece == 8)) return true;
        else if((iBlank == 8) && (iPiece == 7 || iPiece == 5)) return true;
        else return false;
    }

    private Vector2 blankPos(){
        if(iBlank == 0) return new Vector2(-400,400);
        else if(iBlank == 1) return new Vector2(0,400);
        else if(iBlank == 2) return new Vector2(400,400);
        else if(iBlank == 3) return new Vector2(-400,0);
        else if(iBlank == 4) return new Vector2(0,0);
        else if(iBlank == 5) return new Vector2(400,0);
        else if(iBlank == 6) return new Vector2(-400,-400);
        else if(iBlank == 7) return new Vector2(0,-400);
        else return new Vector2(400,-400);
    }
}
