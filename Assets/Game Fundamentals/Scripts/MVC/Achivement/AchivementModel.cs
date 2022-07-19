using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AchivementMVC;
using AchivementSO;

namespace AchivementMVC
{
    public class AchivementModel
    {
        public AchivementObstacle achivementObstacle { get; private set; }
        public AchivementStar achivementStar { get; private set; }

        public AchivementModel(AchivementHolder achivement)
        {
            this.achivementObstacle = achivement.achivementObstacle;
            this.achivementStar = achivement.achivementStar;
        }
    }
}
