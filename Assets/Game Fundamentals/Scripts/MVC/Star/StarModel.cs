using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarMVC;
using StarScriptable;

namespace StarMVC
{
    public class StarModel 
    {
        public int score { get; private set; }
        public Sprite image { get; private set; }
        public StarView starView { get; private set; }
        public StarModel(StarScriptableObject starScriptable)
        {
            starScriptable.score = score;
            starScriptable.image = image;
            starScriptable.starView = starView;
        }
    }
}
