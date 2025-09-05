using UnityEngine;

public class DynamicCameraAdjuster : MonoBehaviour
{
    [Tooltip("The camera to adjust. Leave empty to use Camera.main")]
    public Camera mainCamera;

    // Set your base aspect ratio here (portrait mode: 9:16)
    public float baseAspectWidth = 9f;
    public float baseAspectHeight = 16f;

    void Start()
    {
        // Force portrait orientation
        Screen.orientation = ScreenOrientation.Portrait;

        // Automatically assign the main camera if none is set
        if (mainCamera == null)
            mainCamera = Camera.main;

        AdjustCameraSize();
    }

    void AdjustCameraSize()
    {
        float currentAspect = (float)Screen.width / Screen.height;
        float baseAspect = baseAspectWidth / baseAspectHeight;

        if (currentAspect > baseAspect)
        {
            float difference = currentAspect / baseAspect;
            mainCamera.orthographicSize /= difference;
        }
        else if (currentAspect < baseAspect)
        {
            float difference = baseAspect / currentAspect;
            mainCamera.orthographicSize *= difference;
        }
    }
}