using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AchivementSO;

namespace AchivementSO
{
    [CreateAssetMenu(fileName = "Achievement Holder", menuName = "Scriptable Object/Achievement/New Achievement List SO")]
    public class AchivementHolder : ScriptableObject
    {
        public AchivementObstacle achivementObstacle;
        public AchivementStar achivementStar;
    }
}

