using UnityEngine;
using FishingGame;

[CreateAssetMenu(fileName = "New Fish", menuName = "Fishing Game/Fish Data")]
public class FishData : ScriptableObject
{
    [Header("Fish Identity")]
    public string fishName = "New Fish";
    public FishGrade grade = FishGrade.D;
    public Sprite fishSprite;
    public GameObject fishPrefab;

    [Header("Fish Stats")]
    public float power;          // Fish power level
    public float catchPower;     // Negative value for escape points
    public float breakPoint;     // Maximum escape points before fish flees
    public float maxHP;          // Fish health points
    public float reward;         // Money reward when caught
}
