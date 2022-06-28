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
        private GameObject spawnner;
        private Transform spawnPoint;
        
        public GroundController GetGround(GroundModel groundModel,GameObject destroyer,GameObject spawnner,Transform spawnPoint)
        {
            this.groundModel = groundModel;
            this.destroyer = destroyer;
            this.spawnner = spawnner;
            this.spawnPoint = spawnPoint;
            return CreateItem();
        }
        protected override GroundController CreateItem()
        {
            GroundController groundController = new GroundController(groundModel, destroyer, spawnner,spawnPoint);
            return groundController;
        }
    }
}
