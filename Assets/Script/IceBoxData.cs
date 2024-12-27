using UnityEngine;

[CreateAssetMenu(fileName = "New Ice Box", menuName = "Fishing Game/Equipment/Ice Box")]
public class IceBoxData : ScriptableObject
{
    public string boxName;
    public float rewardMultiplier = 1.2f;
    public Sprite boxSprite;
}
