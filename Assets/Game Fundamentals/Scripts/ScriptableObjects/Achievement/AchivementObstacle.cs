using UnityEngine;
using System;

namespace AchivementSO
{
    [CreateAssetMenu(fileName = "Obstacle Achievement", menuName = "Scriptable Object/Achievement/New Obstacle Achievement SO")]
    public class AchivementObstacle : ScriptableObject
    {
        public AchivementType[] achivements;


        [Serializable]
        public class AchivementType
        {
            public string name;
            public ObstacleAchivement achivement;
            public string info;
            public int requirement;
        }
    }
}
