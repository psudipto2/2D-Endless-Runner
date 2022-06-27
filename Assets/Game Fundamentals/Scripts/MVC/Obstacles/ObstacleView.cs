using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObstacleMVC;
using StateMachine;

namespace ObstacleMVC
{
    public class ObstacleView : MonoBehaviour
    {
        [HideInInspector] public Vector3 scale;
        [HideInInspector] public GameObject destroyer;
        [HideInInspector] public GameObject player;
        private ObstacleController currentController;
        private void Start()
        {
            this.transform.localScale = scale; 
        }
        public void SetController(ObstacleController obstacleController)
        {
            currentController = obstacleController;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject == destroyer)
            {
                Destroy(this.gameObject);
                currentController = null;
            }
            else if (collision.gameObject == player)
            {
                Destroy(player);
            }
            else if (collision.CompareTag("Obstacle"))
            {
                Destroy(this.gameObject);
                ObstacleService.Instance.CreateNewObstacle(ObstacleService.Instance.obstacle);
                currentController = null;
            }
        }

    }
}
