using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorTexture; // Arraste sua imagem do cursor aqui
    public Vector2 hotSpot = Vector2.zero;
    public GameObject lightTrailPrefab; // Prefab do rastro de luz
    public float trailUpdateInterval = 0.1f; // Intervalo de atualização do rastro
    public float trailDuration = 1.0f; // Duração do rastro

    private LineRenderer lineRenderer;
    private GameObject currentTrail;

    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.Auto);

        lineRenderer = GetComponent<LineRenderer>();
        if (lineRenderer == null)
        {
            lineRenderer = gameObject.AddComponent<LineRenderer>();
            lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
            lineRenderer.startWidth = 0.1f;
            lineRenderer.endWidth = 0.1f;
        }

        StartCoroutine(UpdateTrail());
    }

    IEnumerator UpdateTrail()
    {
        while (true)
        {
            Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cursorPosition.z = 0;

            if (currentTrail == null)
            {
                currentTrail = Instantiate(lightTrailPrefab, cursorPosition, Quaternion.identity);
                Destroy(currentTrail, trailDuration);
            }

            lineRenderer.positionCount = 2;
            lineRenderer.SetPosition(0, cursorPosition);
            lineRenderer.SetPosition(1, currentTrail.transform.position);

            yield return new WaitForSeconds(trailUpdateInterval);
        }
    }
}

