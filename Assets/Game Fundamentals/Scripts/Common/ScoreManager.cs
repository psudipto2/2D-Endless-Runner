using UnityEngine;
using Singleton;
using TMPro;

namespace Common
{
    public class ScoreManager : MonoSingletonGeneric<ScoreManager>
    {
        [SerializeField] private TextMeshProUGUI ScoreText;
        private int playerScore;

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

