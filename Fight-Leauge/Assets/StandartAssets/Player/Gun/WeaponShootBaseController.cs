using System.Collections.Generic;
using System.Linq;
using FightLeauge.Enemy;
using UnityEngine;

namespace FightLeauge.Weapon
{
    public enum WeaponType { EnemyBase = 0, Ghost };
    public abstract class WeaponShootBaseController : MonoBehaviour
    {
        [SerializeField] private Transform _bulletSpawnPos;
        [SerializeField] protected Transform _player;
        [SerializeField] protected GameObject _bullet;
        [SerializeField] protected WeaponType _weaponType;
        [SerializeField] protected WeaponShootSettings _weaponShootSettings;
        [SerializeField] protected List<EnemyMovementController> _enemyMovementController;

        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private Transform target;
        protected virtual void Shoot()
        {
            foreach(var enemy in _enemyMovementController.Where(enemy => Mathf.Abs(Vector3.Distance(transform.position , rb.position )) <= 2f))
            {
                Debug.Log("Shoot");
                target = enemy.transform;
                float angle = Mathf.Atan2(target.position.y, target.position.x) * Mathf.Rad2Deg + 180f;
                // transform.eulerAngles = new Vector3(0,0,enemy.transform.position.x);
            }
        }
    }
}

