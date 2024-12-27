using UnityEngine;
using UnityEngine.UI;

public class SimpleCatchMeter : MonoBehaviour
{
    [Header("UI References")]
    public Slider slider; // Reference to UI Slider component

    [Header("Movement Settings")]
    public float moveSpeed = 1f;        // Speed of the slider movement
    private bool movingRight = true;    // Direction flag

    void Update()
    {
        // If moving right, increase value
        if (movingRight)
        {
            slider.value += moveSpeed * Time.deltaTime;

            // If we hit the maximum, switch direction
            if (slider.value >= slider.maxValue)
            {
                movingRight = false;
            }
        }
        // If moving left, decrease value
        else
        {
            slider.value -= moveSpeed * Time.deltaTime;

            // If we hit the minimum, switch direction
            if (slider.value <= slider.minValue)
            {
                movingRight = true;
            }
        }
    }
}