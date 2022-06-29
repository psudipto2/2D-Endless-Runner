using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Singleton;
using PlayerMVC;

namespace Common
{
    public class ScoreManager : MonoSingletonGeneric<ScoreManager>
    {
        [SerializeField] private TextMeshProUGUI ScoreText;
        private GameObject player;
        private int playerScore;
        private void Update()
        {
            increaseScoreWithTime();
            displayScore();
        }
        private void displayScore()
        {
            ScoreText.text = playerScore.ToString();
        }
        private void increaseScoreWithTime()
        {
            player = PlayerService.Instance.SetPlayer();
            if (player != null)
            {
                float scoreForTime = 0;
                scoreForTime += 1 * Time.deltaTime;
            }

        }
        public void increaseScore(int score)
        {
            playerScore += score;
        }
    }
}

