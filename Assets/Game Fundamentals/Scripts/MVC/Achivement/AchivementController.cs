using UnityEngine;
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
            currentObstaclePassedTier = PlayerPrefs.GetInt("currentObstaclePassedTier");
            currentStarsCollectedTier = PlayerPrefs.GetInt("currentStarsCollectedTier");
            this.achivementModel = achivementModel;
        }
        public void CheckForObstaclePassedAchivement()
        {
            for (int i = 0; i < achivementModel.achivementObstacle.achivements.Length; i++)
            {
                if (i != currentObstaclePassedTier) continue;
                if (PlayerPrefs.GetInt("obstaclePassed") == achivementModel.achivementObstacle.achivements[i].requirement)
                {
                    UnlockAchivement(achivementModel.achivementObstacle.achivements[i].name, achivementModel.achivementObstacle.achivements[i].info);
                    currentObstaclePassedTier = i + 1;
                    PlayerPrefs.SetInt("currentObstaclePassedTier", currentObstaclePassedTier);
                }
                break;
            }
        }

        public void CheckForStarCollectedAchivement()
        {
            for(int i = 0; i < achivementModel.achivementStar.achivements.Length; i++)
            {
                if (i != currentStarsCollectedTier) continue;
                if (PlayerPrefs.GetInt("starCollected") == achivementModel.achivementStar.achivements[i].requirement)
                {
                    UnlockAchivement(achivementModel.achivementStar.achivements[i].name, achivementModel.achivementStar.achivements[i].info);
                    currentStarsCollectedTier += 1;
                    PlayerPrefs.SetInt("currentStarsCollectedTier", currentStarsCollectedTier);
                }
                break;
            }
        }

        private void UnlockAchivement(string achivementName,string achivementInfo)
        {
            GameService.Instance.ShowAchivementUnlocked(achivementName, achivementInfo);
        }
    }
}
