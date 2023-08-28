using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FontSizeController : MonoBehaviour
{
    public Slider fontSizeSlider; // Referência ao Slider

    private void Start()
    {
        // Adicionar um listener ao evento de mudança do slider
        fontSizeSlider.onValueChanged.AddListener(UpdateFontSize);
    }

    private void UpdateFontSize(float newSize)
    {
        Text[] textComponents = FindObjectsOfType<Text>();
        foreach (Text textComponent in textComponents)
        {
            textComponent.fontSize = (int)newSize;
        }
        TextMeshProUGUI[] tmpComponents = FindObjectsOfType<TextMeshProUGUI>();
        foreach (TextMeshProUGUI tmpComponent in tmpComponents)
        {
            tmpComponent.fontSize = newSize;
        }
    }
}
