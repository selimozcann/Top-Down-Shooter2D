using UnityEngine;

namespace FightLeauge.Enemy
{
    [CreateAssetMenu(fileName = "EnemyMovementControllerSettings",menuName = "Enemy/EnemyMovementControllerSettings")]
    public class EnemyMovementControllerSettings : ScriptableObject
    {
        [SerializeField] private float speed;
        public float Speed { get{ return speed;} }

        [SerializeField] private float lerpTime;
        public float LerpTime { get { return lerpTime;} }

        [SerializeField] private Vector3 targetOffset;
        public Vector3 TargetOffset { get { return  targetOffset;} }
    }
}
