using UnityEngine;
using GroundMVC;

namespace GroundScriptable
{
    [CreateAssetMenu(fileName = "Ground Scriptable Object", menuName = "Scriptable Object/Ground/New Ground Scriptable Object")]
    public class GroundScriptableObject : ScriptableObject
    {
        public GroundView groundView;
        public Sprite image;
    }
}
