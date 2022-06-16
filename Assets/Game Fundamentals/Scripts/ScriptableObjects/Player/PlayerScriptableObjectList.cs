using UnityEngine;
using PlayerScriptable;

namespace PlayerScriptable
{
    [CreateAssetMenu(fileName = "PlayerSOList", menuName = "ScriptableObject/Player/PlayerScriptableObjectList")]
    public class PlayerScriptableObjectList : ScriptableObject
    {
        public PlayerScriptableObject[] players;
    }
}