using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningObstactles : MonoBehaviour
{
    private GameObject SpawnObstacle;
    public List<GameObject> UpGameobjects;
    public List<GameObject> DownGameobjects;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    private void Update()
    {
        if (Time.time > spawnTime)
        {
            ChooseObstacles();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }
    private void ChooseObstacles()
    {
        int rand=Random.Range(0,2);
        if (rand == 1)
        {
            ChooseUpObstacle();
        }
        else
        {
            chooseDownObstacle();
        }
    }
    private void ChooseUpObstacle()
    {
        int UpRand = Random.Range(0, 4);
        float RandomX = Random.Range(minX, maxX);
        switch (UpRand)
        {
            case 0:
                {
                    SpawnObstacle = UpGameobjects[UpRand];
                    break;
                }
            case 1:
                {
                    SpawnObstacle = UpGameobjects[UpRand];
                    break;
                }
            case 2:
                {
                    SpawnObstacle = UpGameobjects[UpRand];
                    break;
                }
            case 3:
                {
                    SpawnObstacle = UpGameobjects[UpRand];
                    break;
                }
        }
        Instantiate(SpawnObstacle, transform.position + new Vector3(RandomX, minY, 0), transform.rotation);
    }
    private void chooseDownObstacle()
    {
        int DownRand = Random.Range(0, 3);
        float RandomX = Random.Range(minX, maxX);
        switch (DownRand)
        {
            case 0:
                {
                    SpawnObstacle = DownGameobjects[DownRand];
                    break;
                }
            case 1:
                {
                    SpawnObstacle = DownGameobjects[DownRand];
                    break;
                }
            case 2:
                {
                    SpawnObstacle = DownGameobjects[DownRand];
                    break;
                }
            case 3:
                {
                    SpawnObstacle = DownGameobjects[DownRand];
                    break;
                }
        }
        Instantiate(SpawnObstacle, transform.position + new Vector3(RandomX, maxY, 0), transform.rotation);
    }
}
