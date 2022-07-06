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
        private float scoreForTime;
        private void Update()
        {
            displayScore();
        }
        private void displayScore()
        {
            ScoreText.text = playerScore.ToString();
        }
        public void increaseScore(int score)
        {
            playerScore += score;
        }
    }
}

