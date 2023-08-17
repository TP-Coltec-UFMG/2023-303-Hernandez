using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorTrail : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int maxPoints = 20;  // Número máximo de pontos no rastro
    public float pointSpacing = 0.1f;  // Espaçamento entre os pontos

    private Queue<Vector3> cursorPositions = new Queue<Vector3>();

    private void Start()
    {
        if (lineRenderer == null)
        {
            Debug.LogError("Line Renderer component is not assigned!");
            enabled = false; // Desabilitar o script
            return;
        }
    }

    private void Update()
    {
        // Adicionar a posição atual do cursor à fila
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPosition.z = 0;  // Manter o valor Z constante (2D)
        cursorPositions.Enqueue(cursorPosition);

        // Remover pontos excedentes da fila
        while (cursorPositions.Count > maxPoints)
        {
            cursorPositions.Dequeue();
        }

        // Atualizar os pontos do Line Renderer
        lineRenderer.positionCount = cursorPositions.Count;
        lineRenderer.SetPositions(cursorPositions.ToArray());
        Color randomColor = new Color(255, 0, 0);
        lineRenderer.material.color = randomColor;
    }
}

