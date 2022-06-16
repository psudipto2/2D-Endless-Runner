using UnityEngine;
using ObstacleScriptable;

namespace ObstacleScriptable
{
    [CreateAssetMenu(fileName = "DownObstacleSOList", menuName = "ScriptableObject/Obstacle/Downward/DownObstacleScriptableObjectList")]
    public class DownObstacleSOList : ScriptableObject
    {
        public DownObstacleScriptableObjects[] dObstacles;
    }
}