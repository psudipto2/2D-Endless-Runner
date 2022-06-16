using UnityEngine;
using ObstacleMVC;
using ObstacleScriptable;

namespace ObstacleScriptable
{
    [CreateAssetMenu(fileName = "UpObstacleScriptableObject", menuName = "ScriptableObject/Obstacle/Upward/NewUpScriptableObject")]
    public class UpObstacleScriptableObjects : ScriptableObject
    {
        public ObstacleView uObstacleView;
        public Vector2 Scale;
    }
}