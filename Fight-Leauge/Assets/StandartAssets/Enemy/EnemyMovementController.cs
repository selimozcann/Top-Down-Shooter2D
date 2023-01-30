using UnityEngine;

namespace FightLeauge.Enemy
{
    public class EnemyMovementController : MonoBehaviour
    {
        [SerializeField] private EnemyMovementControllerSettings _enemyMovementControllerSettings;
        [SerializeField] private Transform target;
    
        private void Update()
        {
            SetPositionAndRotation();
            SetToDirection();
        }
        private void SetPositionAndRotation()
        {
            transform.position = 
                Vector3.MoveTowards(transform.position,target.position + _enemyMovementControllerSettings.TargetOffset,_enemyMovementControllerSettings.LerpTime * Time.deltaTime);
        }
        private Vector3 ChangeToLocalScale(Vector3 targetScale)
        {
            return targetScale;
        }

        private void SetToDirection()
        {
            var dif = target.position.x - transform.position.x;
            if (Mathf.Abs(dif) <= .2f)
            {
                return;
            }
            transform.localScale = dif > .2f ? ChangeToLocalScale(new Vector3(-2,transform.localScale.y,transform.localScale.z)) : ChangeToLocalScale(new Vector3(2,transform.localScale.y,transform.localScale.z));
            
        }
    }
}
