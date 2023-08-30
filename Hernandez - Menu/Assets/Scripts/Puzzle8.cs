using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle8 : MonoBehaviour
{
    //private int[] positions = new int[] {7, 4, 3, 6, 1, 9, 2, 8, 5};
    private int[] positions = new int[] {1, 2, 6, 4, 5, 3, 7, 8, 9};
    private int[] reference = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
    private int iBlank;
    GameObject button;

    private void Start() {
        iBlank = FindInArray(3);
    }

    public void MovePiece(int piece){
        int iPiece = FindInArray(piece);

        if (CanMove(iPiece)){

            button = GameObject.Find(piece.ToString());
            button.transform.localPosition = new Vector2(BlankX(), BlankY());

            int swp = iPiece;
            iPiece = iBlank;
            iBlank = swp;

            positions[iBlank] = 3;
            positions[iPiece] = piece;

            if(Confere()){
                Debug.Log("Deu bom");
            }
        }
    }

    public bool Confere(){
        for(int i = 0; i < 9; i++){
            if(!(positions[i] == reference[i])) return false;
        }
        return true;
    }

    private int FindInArray(int piece){
        for (int i = 0; i < 9; i++){
            if (positions[i] == piece) return i;
        }
        return -1;
    }

    private bool CanMove(int iPiece){
        if(iPiece == iBlank + 3 || iPiece == iBlank - 3) return true;
        else if(iBlank % 3 == 0 && iPiece == (iBlank + 1)) return true;
        else if(iBlank % 3 == 1 && (iPiece == (iBlank + 1) || iPiece == (iBlank - 1))) return true;
        else if(iBlank % 3 == 2 && iPiece == (iBlank - 1)) return true;
        else return false;
    }

    private int BlankY(){
        if (iBlank < 3) return 400;
        else if (iBlank < 6) return 0;
        else return -400;
    }

    private int BlankX(){
        if (iBlank % 3 == 0) return -400;
        else if (iBlank % 3 == 1) return 0;
        else return 400;
    }
}
