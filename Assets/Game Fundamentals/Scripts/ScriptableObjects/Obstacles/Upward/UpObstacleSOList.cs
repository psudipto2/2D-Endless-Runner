using UnityEngine;
using ObstacleScriptable;

namespace ObstacleScriptable
{
    [CreateAssetMenu(fileName = "DownObstacleSOList", menuName = "ScriptableObject/Obstacle/Upward/upObstacleScriptableObjectList")]
    public class UpObstacleSOList : ScriptableObject
    {
        public UpObstacleScriptableObjects[] uObstacles;
    }
}