using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GroundMVC;

namespace ObjectPool
{
    public class ObjectToPoolGround : ObjectPooler<GroundController>
    {
        private GroundModel groundModel;
        private GameObject destroyer;
        private Transform spawnPoint;
        
        public GroundController GetGround(GroundModel groundModel,GameObject destroyer,Transform spawnPoint)
        {
            this.groundModel = groundModel;
            this.destroyer = destroyer;
            this.spawnPoint = spawnPoint;
            return CreateItem();
        }
        protected override GroundController CreateItem()
        {
            GroundController groundController = new GroundController(groundModel, destroyer, spawnPoint);
            return groundController;
        }
    }
}
