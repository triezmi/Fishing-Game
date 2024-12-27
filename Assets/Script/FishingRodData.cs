using UnityEngine;
using FishingGame;

[CreateAssetMenu(fileName = "New Fishing Rod", menuName = "Fishing Game/Equipment/Fishing Rod")]
public class FishingRodData : ScriptableObject
{
    [Header("Rod Identity")]
    public string rodName;
    public FishGrade grade;
    public Sprite rodSprite;

    [Header("Rod Stats")]
    public float basePower = 100f;
    public float minPowerMultiplier = 0.7f;
    public float maxPowerMultiplier = 1.2f;
    public float catchPower = 8f;      // Damage dealt to fish HP
    public float fishingDuration = 30f; // Duration in seconds

    // Helper function to get power range
    public float GetMinPower() => basePower * minPowerMultiplier;
    public float GetMaxPower() => basePower * maxPowerMultiplier;
}
