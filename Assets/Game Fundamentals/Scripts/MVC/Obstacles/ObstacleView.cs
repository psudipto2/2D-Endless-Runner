using UnityEngine;
using PlayerMVC;
using Common;

namespace ObstacleMVC
{
    public class ObstacleView : MonoBehaviour
    {
        [HideInInspector] public Vector3 scale;
        [HideInInspector] public Quaternion rotation;
        [HideInInspector] public GameObject destroyer;
        [HideInInspector] public GameObject player;
        [HideInInspector] public GameObject scoreCounter;
        [HideInInspector] public int score;
        public SpriteRenderer obstacleImage;
        private ObstacleController currentController;
        private void Start()
        {
            this.transform.localScale = scale;
            this.transform.rotation = rotation;

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
            }
            else if (collision.gameObject == player)
            {
                player.SetActive(false);
                PlayerService.Instance.DestroyPlayer();
            }
            else if (collision.CompareTag("Obstacle"))
            {
                Destroy(this.gameObject);
                ObstacleService.Instance.CreateNewObstacle(ObstacleService.Instance.obstacle);
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject == scoreCounter)
            {
                EventService.Instance.InvokeOnPassingObstacle();
                ScoreManager.Instance.increaseScore(score);
            }
        }

    }
}
