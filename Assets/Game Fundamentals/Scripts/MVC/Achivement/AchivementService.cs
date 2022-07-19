using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using AchivementMVC;
using AchivementSO;

namespace AchivementMVC
{
    public class AchivementService : MonoSingletonGeneric<AchivementService>
    {
        public AchivementHolder achivements;
        private AchivementController achivementController;
        private void Start()
        {
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
