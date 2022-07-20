using UnityEngine;

namespace PlayerScriptable
{
    [CreateAssetMenu(fileName = "Player Scriptable Object", menuName = "Scriptable Object/Player/New Player Scriptable Object")]
    public class PlayerScriptableObject : ScriptableObject
    {

        public float Speed;
    }
}