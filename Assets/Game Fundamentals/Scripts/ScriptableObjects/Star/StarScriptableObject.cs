using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarMVC;
using StarScriptable;

namespace StarScriptable
{
    [CreateAssetMenu(fileName = "Star Scriptable Object", menuName = "Scriptable Object/Star/New Star Scriptable Object")]
    public class StarScriptableObject : ScriptableObject
    {
        public int score;
        public Sprite image;
        public StarView starView;
    }
}
