using UnityEngine;
using StarMVC;

namespace ObjectPool
{
    public class ObjectToPoolStar : ObjectPooler<StarController>
    {
        private StarModel starModel;
        private Transform spawnPoint;
        private GameObject player;
        private GameObject destroyer;
        public StarController GetStar(StarModel starModel,Transform spawnPoint,GameObject player,GameObject destroyer)
        {
            this.starModel = starModel;
            this.spawnPoint = spawnPoint;
            this.player = player;
            this.destroyer = destroyer;
            return CreateItem();
        }
        protected override StarController CreateItem()
        {
            StarController starController = new StarController(starModel, spawnPoint, player,destroyer);
            return starController;
        }
    }
}
