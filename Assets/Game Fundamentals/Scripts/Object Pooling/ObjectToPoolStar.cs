using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjectPool;
using StarMVC;

namespace ObjectPool
{
    public class ObjectToPoolStar : ObjectPooler<StarController>
    {
        private StarModel starModel;
        private Transform spawnPoint;
        private GameObject player;
        public StarController GetStar(StarModel starModel,Transform spawnPoint,GameObject player)
        {
            this.starModel = starModel;
            this.spawnPoint = spawnPoint;
            this.player = player;
            return CreateItem();
        }
        protected override StarController CreateItem()
        {
            StarController starController = new StarController(starModel, spawnPoint, player);
            return starController;
        }
    }
}
