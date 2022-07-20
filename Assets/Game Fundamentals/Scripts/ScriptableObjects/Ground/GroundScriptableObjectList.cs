using UnityEngine;

namespace GroundScriptable
{
    [CreateAssetMenu(fileName = "Ground SO List", menuName = "Scriptable Object/Ground/New Ground Scriptable Object List")]
    public class GroundScriptableObjectList : ScriptableObject
    {
        public GroundScriptableObject[] groundList;
    }
}
