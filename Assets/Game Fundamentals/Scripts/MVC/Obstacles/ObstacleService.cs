using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using ObstacleMVC;
using PlayerMVC;
using ObstacleScriptable;
using StateMachine;
using ObjectPool;

namespace ObstacleMVC
{
    public class ObstacleService : MonoSingletonGeneric<ObstacleService>
    {
        [SerializeField] private GameObject destroyer;
        [HideInInspector] public ObstacleScriptableObject obstacle;
        private GameObject player;
        [SerializeField] private Transform SpawnPoint;
        [SerializeField] private GameObject scoreCounter;
        private List<ObstacleController> obstacles = new List<ObstacleController>();
        private ObstacleModel currentModel;
        private ObstacleController obstacleController;
        [SerializeField] private ObjectToPoolObstacle poolObstacle;

        public void CreateNewObstacle(ObstacleScriptableObject obstacle)
        {
            this.obstacle = obstacle;
            ObstacleModel obstacleModel = new ObstacleModel(this.obstacle);
            currentModel = obstacleModel;
            SpawnPoint.position = CreateNewSpawnPoint(currentModel);
            //SpawnPoint.rotation = GetRotation(currentModel);
            player = PlayerService.Instance.SetPlayer();
            obstacleController = poolObstacle.GetObsatacle(obstacleModel, destroyer, player, SpawnPoint,scoreCounter);
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
        private Quaternion GetRotation(ObstacleModel obstacleModel)
        {
            Quaternion rotation = new Quaternion();
            if (obstacleModel.obstacleDirection == ObstacleDirection.Downward)
            {
                rotation.x = 0f;
                rotation.y = 180f;
                rotation.z = 180f;
                rotation.w = 0f;
                Debug.Log(rotation);
                return rotation;
            }
            return rotation;
        }
        public ObstacleModel GetObstacleModel()
        {
            return currentModel;
        }
    }
}
