using UnityEngine;
using System.Collections.Generic;

namespace FishingGame
{
    [CreateAssetMenu(fileName = "FishDatabase", menuName = "Fishing Game/Fish Database")]
    public class FishDatabase : ScriptableObject
    {
        public List<FishData> fishList = new List<FishData>();
    }
}