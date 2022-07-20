using UnityEngine;

namespace AchivementSO
{
    [CreateAssetMenu(fileName = "Achievement Holder", menuName = "Scriptable Object/Achievement/New Achievement List SO")]
    public class AchivementHolder : ScriptableObject
    {
        public AchivementObstacle achivementObstacle;
        public AchivementStar achivementStar;
    }
}

