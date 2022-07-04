using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarScriptable
{
    [CreateAssetMenu(fileName = "Star SO List", menuName = "Scriptable Object/Star/New Star Scriptable Object List")]
    public class StarScriptableObjectList : ScriptableObject
    {
        public StarScriptableObject[] stars;
    }
}
