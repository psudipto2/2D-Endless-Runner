using UnityEngine;
using ObstacleMVC;
using ObstacleScriptable;

namespace ObstacleScriptable
{
    [CreateAssetMenu(fileName = "DownObstacleScriptableObject", menuName = "ScriptableObject/Obstacle/Downward/NewDownScriptableObject")]
    public class DownObstacleScriptableObjects : ScriptableObject
    {
        public ObstacleView dObstacleView;
        public Vector2 Scale;
    }
}