using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using GroundMVC;
using GroundScriptable;
using ObjectPool;

namespace GroundMVC
{
    public class GroundService : MonoSingletonGeneric<GroundService>
    {
        private GroundScriptableObject ground;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private GameObject destroyer;
        [SerializeField] private GameObject spawnner;
        [SerializeField] private ObjectToPoolGround poolGround;
        private GroundController groundController;
        private List<GroundController> grounds = new List<GroundController>();

        public void CreateNewGround(GroundScriptableObject ground)
        {
            this.ground = ground;
            GroundModel groundModel = new GroundModel(this.ground);
            spawnPoint.position = CreateNewSpawnPoint();
            groundController = poolGround.GetGround(groundModel, destroyer, spawnner, spawnPoint);
            grounds.Add(groundController);
        }
        public void ReturnGround(GroundController groundController)
        {
            poolGround.ReturnItem(groundController);
        }
        private Vector3 CreateNewSpawnPoint()
        {
            float newPointX = 0f;
            float newPointY = -4.3f;
            Vector3 newPoint = new Vector3();
            newPoint.x = spawnPoint.position.x+newPointX;
            newPoint.y = newPointY;
            return newPoint;
        }
    }
}