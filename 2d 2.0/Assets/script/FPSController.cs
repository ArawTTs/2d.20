using UnityEngine;
using UnityEngine.UI;

public class FPSController : MonoBehaviour
{
    public Text fpsText;

    private void Start()
    {
        // Initialize the FPS text
        UpdateFPSText();

        // Set the initial FPS to 60 (you can change this to your preferred default)
        SetTargetFPS(60);
    }

    private void Update()
    {
        // Update the FPS text every frame
        UpdateFPSText();
    }

    public void SetTargetFPS(int fps)
    {
        // Set the target FPS using Application.targetFrameRate
        Application.targetFrameRate = fps;
    }

    private void UpdateFPSText()
    {
        // Display the current FPS setting on the UI Text element
        if (fpsText != null)
        {
            int currentFPS = (int)(1f / Time.deltaTime);
            fpsText.text = "FPS: " + currentFPS;
        }
    }
}

