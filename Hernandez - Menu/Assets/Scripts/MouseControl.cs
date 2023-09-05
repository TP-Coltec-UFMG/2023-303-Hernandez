using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    [SerializeField] private Texture2D defaultCursor, clickableCursor, defaultCursorComp, clickableCursorComp, textCursor;
    [SerializeField] private Vector2 hotspot;
    [SerializeField] private Vector2 hotspotDefC;
    [SerializeField] private Vector2 hotspotClickC;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Alpha1)) Cursor.SetCursor(defaultCursor, hotspot, CursorMode.Auto);
        if(Input.GetKeyDown(KeyCode.Alpha2)) Cursor.SetCursor(clickableCursor, hotspot, CursorMode.Auto);
    }

    public void OnButtonCursorEnter(){
        Cursor.SetCursor(clickableCursor, hotspot, CursorMode.Auto);
    }

    public void OnButtonCursorExit(){
        Cursor.SetCursor(defaultCursor, hotspot, CursorMode.Auto);
    }

    public void OnButtonCursorEnterComputer(){
        Cursor.SetCursor(clickableCursorComp, hotspotDefC, CursorMode.Auto);
    }

    public void OnButtonCursorExitComputer(){
        Cursor.SetCursor(defaultCursorComp, hotspotClickC, CursorMode.Auto);
    }

    public void OnButtonCursorEnterText(){
        Cursor.SetCursor(textCursor, hotspot, CursorMode.Auto);
    }
}
