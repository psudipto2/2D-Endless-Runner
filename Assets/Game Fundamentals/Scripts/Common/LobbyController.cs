using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayerMVC;
using PlayerScriptable;
using Singleton;
using UnityEngine.SceneManagement;

namespace Common
{
    public class LobbyController : MonoSingletonGeneric<LobbyController>
    {
        [SerializeField] private GameObject levelScreen;
        private int level;
        public void PlayButton()
        {
            levelScreen.SetActive(true);
        }
        public void EasyLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            level = 0;
        }
        public void MediumLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            level = 1;
        }
        public void HardLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            level = 2;
        }
        public void ExtremeLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            level = 3;
        }
        public int setLevel()
        {
            return level;
        }
    }
}
