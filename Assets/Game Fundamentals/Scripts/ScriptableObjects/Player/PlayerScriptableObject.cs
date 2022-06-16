using UnityEngine;
using PlayerMVC;
using PlayerScriptable;

namespace PlayerScriptable
{
    [CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "ScriptableObject/Player/NewPlayerScriptableObject")]
    public class PlayerScriptableObject : ScriptableObject
    {

        public float Speed;
    }
}