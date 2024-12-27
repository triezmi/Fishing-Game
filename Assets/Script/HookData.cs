using UnityEngine;

[CreateAssetMenu(fileName = "New Hook", menuName = "Fishing Game/Equipment/Hook")]
public class HookData : ScriptableObject
{
    public string hookName;
    public float lowerPowerBonus = 10f;
    public Sprite hookSprite;
}
