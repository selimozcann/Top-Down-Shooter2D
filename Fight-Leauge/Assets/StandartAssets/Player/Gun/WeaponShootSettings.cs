using UnityEngine;
using UnityEngine.Serialization;

namespace FightLeauge.Weapon
{
    [CreateAssetMenu(fileName = "WeaponShootSettings",menuName = "Weapon/WeaponShootSettings")]
    public class WeaponShootSettings : ScriptableObject
    {
        [SerializeField] private float shootSpeed;
        public float ShootSpeed { get { return shootSpeed;} }
    }
}
