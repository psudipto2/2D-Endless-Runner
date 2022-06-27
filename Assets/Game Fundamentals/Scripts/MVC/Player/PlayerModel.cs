using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerMVC;
using PlayerScriptable;

namespace PlayerMVC
{
    public class PlayerModel
    {
        public float Speed { get; private set; }
        public PlayerModel(PlayerScriptableObject playerScriptable)
        {
            Speed = playerScriptable.Speed;
        }
    }
}
