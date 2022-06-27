using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerMVC;

namespace PlayerMVC
{
    public class PlayerView : MonoBehaviour
    {
        [HideInInspector] public Rigidbody2D rb;
        private PlayerController currentPlayerController;
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            currentPlayerController.GetInput();
        }
        private void FixedUpdate()
        {
            currentPlayerController.MovePlayer();
        }
        public void SetPlayerController(PlayerController playerController)
        {
            currentPlayerController = playerController;
        }
        public GameObject setPlayer()
        {
            return this.gameObject;
        }
    }
}


