using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Equipment Database", menuName = "Fishing Game/Equipment Database")]
public class EquipmentDatabase : ScriptableObject
{
    [Header("Fishing Rods")]
    public List<FishingRodData> fishingRods = new List<FishingRodData>();

    [Header("Hooks")]
    public List<HookData> hooks = new List<HookData>();

    [Header("Baits")]
    public List<BaitData> baits = new List<BaitData>();

    [Header("Strings")]
    public List<StringData> strings = new List<StringData>();

    [Header("Ice Boxes")]
    public List<IceBoxData> iceBoxes = new List<IceBoxData>();
}
