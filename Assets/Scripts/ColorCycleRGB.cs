using UnityEngine;
using System.Collections;

public class ColorCycleRGB : MonoBehaviour
{
    public Color[] colors = { Color.red, Color.blue, Color.green, Color.yellow, Color.magenta };
    public float transitionDuration = 1.5f;

    private Renderer objRenderer;
    private int colorIndex = 0;

    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        if (objRenderer != null && colors.Length > 1)
        {
            StartCoroutine(CycleColors());
        }
    }

    private IEnumerator CycleColors()
    {
        while (true)
        {
            Color startColor = colors[colorIndex];
            Color targetColor = colors[(colorIndex + 1) % colors.Length];
            colorIndex = (colorIndex + 1) % colors.Length;

            float elapsedTime = 0f;
            while (elapsedTime < transitionDuration)
            {
                objRenderer.material.color = Color.Lerp(startColor, targetColor, elapsedTime / transitionDuration);
                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }
    }
}