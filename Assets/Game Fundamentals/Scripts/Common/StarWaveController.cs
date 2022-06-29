using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarMVC;

namespace Common
{
    public class StarWaveController : MonoBehaviour
    {
        private float spawnWaveTime;
        private float timeBeetweenWave=5f;
        private void Update()
        {
            if (Time.time > spawnWaveTime)
            {
                StarService.Instance.CreateNewWave();
                spawnWaveTime = Time.time + timeBeetweenWave;
                Debug.Log("Star wave updated");
            }
            
        }
    }
}
