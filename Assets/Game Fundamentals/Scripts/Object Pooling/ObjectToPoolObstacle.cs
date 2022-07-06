using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjectPool;
using ObstacleMVC;

public class ObjectToPoolObstacle : ObjectPooler<ObstacleController>
{
    private ObstacleModel obstacleModel;
    private GameObject destroyer;
    private GameObject player;
    private GameObject scoreCounter;
    private Transform spawnpoint;

    public ObstacleController GetObsatacle(ObstacleModel obstacleModel,GameObject destroyer,GameObject player,Transform spawnpoint,GameObject scoreCounter)
    {
        this.obstacleModel = obstacleModel;
        this.destroyer = destroyer;
        this.player = player;
        this.spawnpoint = spawnpoint;
        this.scoreCounter = scoreCounter;
        return CreateItem();
    }
    protected override ObstacleController CreateItem()
    {
        ObstacleController obstacleController = new ObstacleController(obstacleModel, obstacleModel.ObstacleView, spawnpoint, destroyer, player,scoreCounter);
        return obstacleController;
    }
}
