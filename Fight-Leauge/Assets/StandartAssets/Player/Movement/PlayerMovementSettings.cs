using UnityEngine;

namespace FightLeauge.MovementSettings
{
    [CreateAssetMenu(fileName = "PlayerMovementSettings",menuName = "Player/PlayerMovementSettings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [SerializeField] private Vector2 clampValues;
        public Vector2 ClampValues { get{ return  clampValues;} }

        [SerializeField] private Vector3 targetRotate;
        public Vector3 TargetRotate { get{ return  targetRotate;} }
        
        [SerializeField] private float playerSpeed;
        public float PlayerSpeed { get{ return playerSpeed;} }
        
        [SerializeField] private float targetDistance;
        public float TargetDistance { get{ return targetDistance;} }

        [SerializeField] private float difDirection;
        public float DifDirection  { get { return difDirection; } }
    }
}
