using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using PlayerMVC;
using UnityEngine.SceneManagement;

namespace Common
{
    public class GameService : MonoSingletonGeneric<GameService>
    {
        [SerializeField] private GameObject gameOverCanvas;
        [SerializeField] private GameObject gamePauseCanvas;
        private GameObject player;

        private void Update()
        {
            if (player.activeInHierarchy==false)
            {
                gameOverCanvas.SetActive(true);
                Time.timeScale = 0;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gamePauseCanvas.SetActive(true);
                Time.timeScale = 0;
            }
        }
        public void Resume()
        {
            gamePauseCanvas.SetActive(false);
            Time.timeScale = 1;
        }
        public void Restart()
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        public void MainMenu()
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex-1);
        }
        public void Quit()
        {
            Application.Quit();
        }
        public void getPlayer(GameObject player)
        {
            this.player = player;
        }
    }
}
