using AchivementSO;
using UnityEngine;
using Singleton;

namespace AchivementMVC
{
    public class AchivementService : MonoSingletonGeneric<AchivementService>
    {
        public AchivementHolder achivements;
        private AchivementController achivementController;
        private void Start()
        {
            PlayerPrefs.SetInt("currentObstaclePassedTier", 0);
            PlayerPrefs.SetInt("currentObstaclePassedTier", 0);
            CreateAchivementMVC();
        }
        public void CreateAchivementMVC()
        {
            AchivementModel achivementModel = new AchivementModel(achivements);
            AchivementController achivementController = new AchivementController(achivementModel);
            this.achivementController = achivementController;
        }
        public AchivementController GetAchivementController()
        {
            return achivementController;
        }
    }
}
