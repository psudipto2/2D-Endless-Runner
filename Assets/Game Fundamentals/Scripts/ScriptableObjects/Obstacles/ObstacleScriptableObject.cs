using UnityEngine;
using ObstacleMVC;

namespace ObstacleScriptable
{
    [CreateAssetMenu(fileName = "Obstacle Scriptable Object", menuName = "Scriptable Object/Obstacle/New Obstacle Scriptable Object")]
    public class ObstacleScriptableObject : ScriptableObject
    {
        public ObstacleDirection obstacleDirection;
        public ObstacleType obstacleType;
        public ObstacleView ObstacleView;
        public Vector3 Scale;
        public Quaternion rotation;
        public int score;
        public float maxY;
        public Sprite image;
    }
}