using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarMVC;
using Common;

namespace StarMVC
{
    public class StarView : MonoBehaviour
    {
        public SpriteRenderer spriteRenderer;
        [HideInInspector] public int score;
        [HideInInspector] public GameObject player;
        private StarController starController;

        public void setController(StarController starController)
        {
            this.starController = starController;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject == player)
            {
                Destroy(gameObject);
                ScoreManager.Instance.increaseScore(score);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
