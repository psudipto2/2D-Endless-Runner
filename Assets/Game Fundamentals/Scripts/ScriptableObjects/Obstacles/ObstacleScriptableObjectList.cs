using UnityEngine;

namespace ObstacleScriptable
{
    [CreateAssetMenu(fileName = "Obstacle SO List", menuName = "Scriptable Object/Obstacle/New Obstacle Scriptable Object List")]
    public class ObstacleScriptableObjectList : ScriptableObject
    {
        public ObstacleScriptableObject[] Obstacles;
    }
}