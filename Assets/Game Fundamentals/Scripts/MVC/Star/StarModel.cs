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
            this.score = starScriptable.score;
            this.image = starScriptable.image;
            this.starView = starScriptable.starView;
        }
    }
}
