using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
using Singleton;
using TMPro;

namespace Common
{
    public class GameService : MonoSingletonGeneric<GameService>
    {
        [SerializeField] private GameObject gameOverCanvas;
        [SerializeField] private GameObject gamePauseCanvas;
        [SerializeField] private GameObject achivementCanvas;
        [SerializeField] private TextMeshProUGUI achivementName;
        [SerializeField] private TextMeshProUGUI achivementInfo;

        private GameObject player;
        private GameObject activeCanvas;

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
                activeCanvas = gamePauseCanvas;
                Time.timeScale = 0;
            }
        }
        public void Resume()
        {
            activeCanvas.SetActive(false);
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
        public void ShowAchivementUnlocked(string name, string info)
        {
            achivementName.text = name;
            achivementInfo.text = info;
            achivementCanvas.SetActive(true);
            Time.timeScale = 0;
            activeCanvas = achivementCanvas;
        }

        private IEnumerator StartWaiting()
        {
            yield return new WaitForSeconds(3f);
        }
    }
}
