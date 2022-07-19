using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using AchivementSO;

namespace AchivementSO
{
    [CreateAssetMenu(fileName = "Star Achievement", menuName = "Scriptable Object/Achievement/New Star Achievement SO")]
    public class AchivementStar : ScriptableObject
    {
        public AchivementType[] achivements;

        [Serializable]
        public class AchivementType
        {
            public string name;
            public StarAchivement achivement;
            public string info;
            public int requirement;
        }
    }
}
