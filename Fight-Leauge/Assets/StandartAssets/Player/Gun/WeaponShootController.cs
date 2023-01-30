using System;

namespace FightLeauge.Weapon
{
    public class WeaponShootController : WeaponShootBaseController
    {
        private Action OnShoot;

        private void OnEnable()
        {
            SubscribeToEvent();
        }
        private void OnDisable()
        {
            UnSubscribeToEvent();
        }
        void SubscribeToEvent()
        {
            OnShoot += Shoot;
        }
        void UnSubscribeToEvent()
        {
            OnShoot -= Shoot;
        }
        private void Update()
        {
           Shoot();
        }
        protected override void Shoot()
        {
            base.Shoot();
        }
    }

}
