using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerMVC;
using Common;

namespace PlayerMVC
{
    public class PlayerController
    {
        public PlayerModel playerModel { get; }
        public PlayerView playerView { get; }
        private Rigidbody2D rigidbody;
        private float playerSpeed;
        private Vector2 direction;
        public PlayerController(PlayerModel playerModel, PlayerView playerView)
        {
            this.playerModel = playerModel;
            this.playerView = playerView;
            this.playerView.SetPlayerController(this);
            rigidbody = this.playerView.GetComponent<Rigidbody2D>();
            playerSpeed = playerModel.Speed;
            GameService.Instance.getPlayer(this.playerView.gameObject);
        }
        public void GetInput()
        {
            float directionY = Input.GetAxisRaw("Vertical");
            direction = new Vector2(0, directionY).normalized;
        }
        public void MovePlayer()
        {
            rigidbody.velocity = new Vector2(0, direction.y * playerSpeed);
        }
    }
}

