using UnityEngine;

[CreateAssetMenu(fileName = "New Bait", menuName = "Fishing Game/Equipment/Bait")]
public class BaitData : ScriptableObject
{
    public string baitName;
    public float higherPowerBonus = 20f;
    public Sprite baitSprite;
}
