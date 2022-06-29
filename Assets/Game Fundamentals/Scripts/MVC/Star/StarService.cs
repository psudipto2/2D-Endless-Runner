using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using StarMVC;
using StarScriptable;
using ObjectPool;
using PlayerMVC;

namespace StarMVC
{
    public class StarService : MonoSingletonGeneric<StarService>
    {
        private GameObject Player;
        [SerializeField] private StarScriptableObjectList starList;
        [SerializeField] private ObjectToPoolStar poolStar;
        [SerializeField] private Transform spawnPoint;
        //private Transform starSpawnPoint;
        [SerializeField] private StarScriptableObject star;
        private StarModel starModel;
        private StarController starController;
        private List<StarController> stars = new List<StarController>();
        public void CreateNewWave()
        {
            int chooseStar = Random.Range(0, 3);
            star = starList.Stars[chooseStar];
            int numberOfStars = Random.Range(4, 7);
            Player = PlayerService.Instance.SetPlayer();
            for(int i = 0; i < numberOfStars; i++)
            {
                spawnPoint.position = CreateNewSpawnPoint(spawnPoint);
                CreateNewStar(star,spawnPoint,Player);
            }
        }
        public void CreateNewStar(StarScriptableObject star,Transform spawnPoint,GameObject player)
        {
            this.star = star;
            StarModel starModel = new StarModel(this.star);
            this.starModel = starModel;
            starController = poolStar.GetStar(this.starModel, spawnPoint, player);
            stars.Add(starController);
        }
        public Vector3 CreateNewSpawnPoint(Transform lastPoint)
        {
            float nextPointX = 2f;
            Vector3 newPoint = new Vector3();
            newPoint.x = lastPoint.position.x + nextPointX;
            newPoint.y = lastPoint.position.y;
            return newPoint;
        }
    }
}
