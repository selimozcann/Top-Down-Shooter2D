using System.Collections.Generic;
using System.Linq;
using FightLeauge.Enemy;
using UnityEngine;

namespace FightLeauge.Weapon
{
    public enum WeaponType { EnemyBase = 0, Ghost };
    public abstract class WeaponShootBaseController : MonoBehaviour
    {
        [SerializeField] protected WeaponType _weaponType;
        
        [SerializeField] private Transform _bulletSpawnPos;
        [SerializeField] protected Transform _player;
        [SerializeField] protected GameObject _bullet;
        [SerializeField] protected WeaponShootSettings _weaponShootSettings;
        [SerializeField] protected List<EnemyMovementController> _enemyMovementController;
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private InputHandler inputHandler;

        [SerializeField] private Transform player;
        protected virtual void Shoot()
        {
            transform.eulerAngles = player.localScale.x <= -1 ? SetToWeaponAngle(180) : SetToWeaponAngle(0);
        }
        private Vector3 SetToWeaponAngle(float offsetAngle)
        {
            Vector3 lookDir = inputHandler.MousePos - transform.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
            return new Vector3(0,0,angle + offsetAngle);
        }
    }
}

