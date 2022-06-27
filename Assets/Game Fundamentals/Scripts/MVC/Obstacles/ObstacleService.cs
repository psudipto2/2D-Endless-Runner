using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using ObstacleMVC;
using PlayerMVC;
using ObstacleScriptable;
using StateMachine;

namespace ObstacleMVC
{
    public class ObstacleService : MonoSingletonGeneric<ObstacleService>
    {
        [SerializeField] private GameObject destroyer;
        [HideInInspector] public ObstacleScriptableObject obstacle;
        private GameObject player;
        [SerializeField] private Transform SpawnPoint;
        private List<ObstacleController> obstacles = new List<ObstacleController>();
        private ObstacleModel currentModel;
        private ObstacleController obstacleController;

        public void CreateNewObstacle(ObstacleScriptableObject obstacle)
        {
            this.obstacle = obstacle;
            ObstacleModel obstacleModel = new ObstacleModel(this.obstacle);
            currentModel = obstacleModel;
            SpawnPoint.position = CreateNewSpawnPoint(currentModel);
            player = PlayerService.Instance.SetPlayer();
            obstacleController = new ObstacleController(currentModel, currentModel.ObstacleView,SpawnPoint,destroyer,player);
            obstacles.Add(obstacleController);
        }
        public Vector3 CreateNewSpawnPoint(ObstacleModel obstacleModel)
        {
            float nextPointX = Random.Range(8, -8);
            float nextPointY = GetYSpawnPoint(obstacleModel);
            Vector3 newPoint = new Vector3();
            newPoint.x = nextPointX + SpawnPoint.position.x;
            newPoint.y = nextPointY;
            return newPoint;
        }
        private float GetYSpawnPoint(ObstacleModel obstacleModel)
        {
            if (obstacleModel.obstacleDirection == ObstacleDirection.Upward)
            {
                return obstacleModel.maxY * -1;
            }
            return obstacleModel.maxY;
        }
    }
}
