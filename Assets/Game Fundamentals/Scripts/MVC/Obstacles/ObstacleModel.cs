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
        public ObstacleType obstacleType { get; set; }
        public ObstacleView ObstacleView { get; set; }
        public Vector3 Scale { get; set; }
        public Quaternion rotation { get; set; }
        public int score { get; set; }
        public float maxY { get; set; }
        public Sprite image { get; set; }

        public ObstacleModel(ObstacleScriptableObject obstacleScriptable)
        {
            this.obstacleDirection = obstacleScriptable.obstacleDirection;
            this.obstacleType = obstacleScriptable.obstacleType;
            this.ObstacleView = obstacleScriptable.ObstacleView;
            this.Scale = obstacleScriptable.Scale;
            this.rotation = obstacleScriptable.rotation;
            this.score = obstacleScriptable.score;
            this.maxY = obstacleScriptable.maxY;
            this.image = obstacleScriptable.image;
        }
    }
}
