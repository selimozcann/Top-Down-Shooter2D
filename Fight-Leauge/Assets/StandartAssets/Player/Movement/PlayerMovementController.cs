using FightLeauge.InputSettings;
using FightLeauge.MovementSettings;
using UnityEngine;

namespace FightLeauge
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;
        [SerializeField] private PlayerInputSettings _playerInputSettings;
        [SerializeField] private Rigidbody2D _rb;
        
        private Vector3 targetMovePosition;
        private void Update()
        {
            SetDirectionToPlayer();
        }
        private void FixedUpdate()
        { 
            PlayerMoving(); 
        }
        private void PlayerMoving()
        {
            targetMovePosition = new Vector2(Input.GetAxis(_playerInputSettings.Horizontal),Input.GetAxis(_playerInputSettings.Vertical)) * _playerMovementSettings.PlayerSpeed;
            var clampedMovePositionX = Mathf.Clamp((targetMovePosition.x + _rb.position.x) , -_playerMovementSettings.ClampValues.x, _playerMovementSettings.ClampValues.x);
            var clampedMovePositionY = Mathf.Clamp((targetMovePosition.y +_rb.position.y)  , -_playerMovementSettings.ClampValues.y, _playerMovementSettings.ClampValues.y -1f);

            var calculateMovePos =  new Vector2(clampedMovePositionX, clampedMovePositionY);
            _rb.MovePosition(calculateMovePos);
        }
        private void SetDirectionToPlayer()
        {
            if (targetMovePosition.x == 0)
            {
                return;
            }
            transform.localScale = targetMovePosition.x > 0 ? ScaleChanging(Vector3.one) : ScaleChanging(new Vector3(-1,1,1));
        }
        private Vector3 ScaleChanging(Vector3 targetScale)
        {
            return targetScale;
        }
    }
}

