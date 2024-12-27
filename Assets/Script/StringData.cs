using UnityEngine;

[CreateAssetMenu(fileName = "New String", menuName = "Fishing Game/Equipment/String")]
public class StringData : ScriptableObject
{
    public string stringName;
    public float speedReduction = 0.2f;
    public Sprite stringSprite;
}
