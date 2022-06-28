using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GroundMVC;
using GroundScriptable;

namespace GroundMVC
{
    public class GroundModel
    {
        public GroundView groundView { get; private set; }
        public Sprite image { get; private set; }
        public GroundModel(GroundScriptableObject groundScriptable)
        {
            this.groundView = groundScriptable.groundView;
            this.image = groundScriptable.image;
        }
    }
}
