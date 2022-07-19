using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObstacleMVC;
using Common;
using System;
using AchivementMVC;

namespace ObstacleMVC
{
    public class ObstacleController 
    {
        private ObstacleModel obstacleModel;
        private ObstacleView obstacleView;
        public Transform spawnPoint;

        public ObstacleController(ObstacleModel obstacleModel,ObstacleView obstaclePrefab,Transform spawnPoint,GameObject destroyer,GameObject player,GameObject scoreCounter)
        {
            this.obstacleModel = obstacleModel;
            this.spawnPoint = spawnPoint;
            obstacleView = GameObject.Instantiate<ObstacleView>(obstaclePrefab,spawnPoint.position,spawnPoint.rotation);
            obstacleView.scale = obstacleModel.Scale;
            obstacleView.destroyer = destroyer;
            obstacleView.player = player;
            obstacleView.score = obstacleModel.score;
            obstacleView.scoreCounter = scoreCounter;
            obstacleView.obstacleImage.sprite = obstacleModel.image;
            obstacleView.rotation = obstacleModel.rotation;
            obstacleView.SetController(this);
            SubscribeEvents();
        }
        private void SubscribeEvents()
        {
            EventService.Instance.passedObstacle += UpdateOnObstaclePassed;
        }

        private void UpdateOnObstaclePassed()
        {
            obstacleModel.obstaclePassed += 1;
            PlayerPrefs.SetInt("obstaclePassed", obstacleModel.obstaclePassed);
            AchivementService.Instance.GetAchivementController().CheckForObstaclePassedAchivement();
        }
    }
}
