using UnityEngine;
using System.Collections.Generic;
using FishingGame;

public class EquipmentManager : MonoBehaviour
{
    public static EquipmentManager Instance { get; private set; }

    [Header("Equipment Database")]
    public EquipmentDatabase equipmentDB;
    public FishDatabase fishDatabase;

    [Header("Current Equipment")]
    public FishingRodData currentRod;
    public HookData currentHook;
    public BaitData currentBait;
    public StringData currentString;
    public IceBoxData currentBox;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #region Equipment Power Calculations
    private float CurrentMinPower =>
        currentRod.GetMinPower() +
        (currentHook != null ? currentHook.lowerPowerBonus : 0f);

    private float CurrentMaxPower =>
        currentRod.GetMaxPower() +
        (currentBait != null ? currentBait.higherPowerBonus : 0f);

    public float GetCatchPower() => currentRod.catchPower;
    public float GetFishingDuration() => currentRod.fishingDuration;
    #endregion

    #region Equipment Management
    public void EquipRod(FishingRodData rod)
    {
        currentRod = rod;
    }

    public void EquipHook(HookData hook)
    {
        currentHook = hook;
    }

    public void EquipBait(BaitData bait)
    {
        currentBait = bait;
    }

    public void EquipString(StringData fishString)
    {
        currentString = fishString;
    }

    public void EquipBox(IceBoxData box)
    {
        currentBox = box;
    }

    public void UnequipRod() => currentRod = null;
    public void UnequipHook() => currentHook = null;
    public void UnequipBait() => currentBait = null;
    public void UnequipString() => currentString = null;
    public void UnequipBox() => currentBox = null;
    #endregion

    #region Fishing Mechanics
    public List<FishData> GetPossibleFish()
    {
        List<FishData> possibleFish = new List<FishData>();

        foreach (FishData fish in fishDatabase.fishList)
        {
            if (fish.power >= CurrentMinPower &&
                fish.power <= CurrentMaxPower &&
                fish.grade <= currentRod.grade)
            {
                possibleFish.Add(fish);
            }
        }

        return possibleFish;
    }

    public FishData GetRandomFish()
    {
        List<FishData> possibleFish = GetPossibleFish();
        if (possibleFish.Count == 0) return null;

        return possibleFish[Random.Range(0, possibleFish.Count)];
    }

    public float GetCatchMeterSpeed(float baseSpeed)
    {
        return currentString != null ?
            baseSpeed * (1f - currentString.speedReduction) :
            baseSpeed;
    }

    public float CalculateReward(float baseReward)
    {
        return currentBox != null ?
            baseReward * currentBox.rewardMultiplier :
            baseReward;
    }
    #endregion
}
