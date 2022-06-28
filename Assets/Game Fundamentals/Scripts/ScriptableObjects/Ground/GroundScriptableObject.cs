using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GroundScriptable;
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
