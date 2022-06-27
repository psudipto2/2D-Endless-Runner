using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObstacleMVC;
using ObstacleScriptable;

namespace ObstacleMVC
{
    public class ObstacleModel
    {
        public ObstacleDirection obstacleDirection { get; set; }
        public ObstacleView ObstacleView { get; private set; }
        public Vector3 Scale { get; private set; }
        public float maxY { get; private set; }
        public ObstacleModel(ObstacleScriptableObject obstacleScriptable)
        {
            obstacleDirection = obstacleScriptable.obstacleDirection;
            //Debug.Log(obstacleDirection);
            ObstacleView = obstacleScriptable.ObstacleView;
            Scale = obstacleScriptable.Scale;
            maxY = obstacleScriptable.maxY;
        }
    }
}
