using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObstacleMVC;

namespace ObstacleMVC
{
    public class ObstacleController 
    {
        private ObstacleModel obstacleModel;
        private ObstacleView obstacleView;
        public Transform spawnPoint;

        public ObstacleController(ObstacleModel obstacleModel,ObstacleView obstaclePrefab,Transform spawnPoint,GameObject destroyer,GameObject player)
        {
            this.obstacleModel = obstacleModel;
            this.spawnPoint = spawnPoint;
            obstacleView = GameObject.Instantiate<ObstacleView>(obstaclePrefab,spawnPoint.position,spawnPoint.rotation);
            obstacleView.scale = obstacleModel.Scale;
            obstacleView.destroyer = destroyer;
            obstacleView.player = player;
            obstacleView.SetController(this);
        }
    }
}
