using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using PlayerMVC;
using Common;
using PlayerScriptable;

namespace PlayerMVC
{
    public class PlayerService : MonoSingletonGeneric<PlayerService>
    {
        private PlayerView player;
        [SerializeField] private List<GameObject> planes;
        [SerializeField] private PlayerScriptableObjectList playerList;
        private PlayerModel currentPlayerModel;
        private PlayerController currentPlayerController;
        private PlayerScriptableObject playerScriptable;
        private List<PlayerController> players = new List<PlayerController>();
        private void Start()
        {
            CreateNewPlane();
        }
        public void CreateNewPlane()
        {
            int level=LobbyController.Instance.setLevel();
            playerScriptable = playerList.players[level];
            PlayerModel playerModel= new PlayerModel(playerScriptable);
            currentPlayerModel = playerModel;
            planes[level].SetActive(true);
            player = planes[level].GetComponent<PlayerView>();
            currentPlayerController = new PlayerController(playerModel,player);
            players.Add(currentPlayerController);
        }
        public GameObject SetPlayer()
        {
            return currentPlayerController.playerView.setPlayer();
        }
    }
}
