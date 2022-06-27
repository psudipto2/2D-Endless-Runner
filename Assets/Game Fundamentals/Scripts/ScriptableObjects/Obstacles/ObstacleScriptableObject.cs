using UnityEngine;
using ObstacleMVC;
using ObstacleScriptable;

namespace ObstacleScriptable
{
    [CreateAssetMenu(fileName = "Obstacle Scriptable Object", menuName = "Scriptable Object/Obstacle/New Obstacle Scriptable Object")]
    public class ObstacleScriptableObject : ScriptableObject
    {
        public ObstacleDirection obstacleDirection;
        public ObstacleView ObstacleView;
        public Vector3 Scale;
        public float maxY;
    }
}