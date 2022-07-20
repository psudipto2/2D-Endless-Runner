using GroundScriptable;
using UnityEngine;

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
