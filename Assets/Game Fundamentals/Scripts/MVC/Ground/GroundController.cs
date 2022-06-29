using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GroundMVC;

namespace GroundMVC
{
    public class GroundController
    {
        private GroundView groundView;
        private GroundModel groundModel;
        private Transform spawnPoint;
        public GroundController(GroundModel groundModel, GameObject destroyer, Transform spawnPoint)
        {
            this.groundModel = groundModel;
            this.spawnPoint = spawnPoint;
            this.groundView = GameObject.Instantiate<GroundView>(this.groundModel.groundView, spawnPoint.position,spawnPoint.rotation);
            this.groundView.spriteRenderer.sprite = this.groundModel.image;
            this.groundView.destroyer = destroyer;
            this.groundView.SetController(this);
        }
    }
}
