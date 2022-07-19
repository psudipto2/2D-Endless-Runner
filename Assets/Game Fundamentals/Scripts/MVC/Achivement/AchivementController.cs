using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AchivementMVC;
using ObstacleMVC;
using Common;

namespace AchivementMVC
{
    public class AchivementController
    {
        public AchivementModel achivementModel;
        private int currentObstaclePassedTier;
        private int currentStarsCollectedTier;

        public AchivementController(AchivementModel achivementModel)
        {
            currentObstaclePassedTier = PlayerPrefs.GetInt("currentObstaclePassedTier", 0);
            currentStarsCollectedTier = PlayerPrefs.GetInt("currentStarsCollectedTier", 0);
            this.achivementModel = achivementModel;
        }
        public void CheckForObstaclePassedAchivement()
        {
            for(int i = 0; i < achivementModel.achivementObstacle.achivements.Length; i++)
            {
                if (i != currentObstaclePassedTier) continue;
                if (ObstacleService.Instance.GetObstacleModel().obstaclePassed == achivementModel.achivementObstacle.achivements[i].requirement)
                {
                    UnlockAchivement(achivementModel.achivementObstacle.achivements[i].name, achivementModel.achivementObstacle.achivements[i].info);
                    currentObstaclePassedTier = i + 1;
                    PlayerPrefs.SetInt("currentObstaclePassedTier", currentObstaclePassedTier);
                }
                break;
            }
        }
        private void UnlockAchivement(string achivementName,string achivementInfo)
        {
            Debug.Log(achivementInfo);
            GameService.Instance.ShowAchivementUnlocked(achivementName, achivementInfo);
        }
    }
}
