using UnityEngine;
using FishingGame;

public class Fish : MonoBehaviour
{
    [Header("Fish Data")]
    public FishData fishData;        // Reference to the fish's base stats

    [Header("Current Status")]
    public float currentHP;          // Current health during fishing
    public bool isHooked;            // If fish is currently being caught

    [Header("Visual References")]
    public SpriteRenderer fishSprite;
    public Animator fishAnimator;

    private void Start()
    {
        if (fishData != null)
        {
            Initialize(fishData);
        }
    }

    public void Initialize(FishData data)
    {
        fishData = data;
        currentHP = fishData.maxHP;
        isHooked = false;

        // Setup visuals if available
        if (fishSprite != null && data.fishPrefab != null)
        {
            fishSprite.sprite = data.fishPrefab.GetComponent<SpriteRenderer>().sprite;
        }
    }

    // Get fish properties
    public FishGrade GetGrade() => fishData.grade;
    public float GetPower() => fishData.power;
    public float GetCatchPower() => fishData.catchPower;
    public float GetBreakPoint() => fishData.breakPoint;
    public float GetReward() => fishData.reward;
}
