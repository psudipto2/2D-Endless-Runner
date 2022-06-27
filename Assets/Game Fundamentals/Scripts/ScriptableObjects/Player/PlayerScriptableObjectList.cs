using UnityEngine;
using PlayerScriptable;

namespace PlayerScriptable
{
    [CreateAssetMenu(fileName = "Player SO List", menuName = "Scriptable Object/Player/New Player Scriptable Object List")]
    public class PlayerScriptableObjectList : ScriptableObject
    {
        public PlayerScriptableObject[] players;
    }
}