using UnityEngine;

namespace FightLeauge.InputSettings
{
    [CreateAssetMenu(fileName = "PlayerInputSettings", menuName = "Player/PlayerInputSettings")]
    public class PlayerInputSettings : ScriptableObject
    {
        [SerializeField] private string horizontal;
        public string Horizontal { get { return horizontal;} }
    
        [SerializeField] private string vertical;
        public string Vertical { get{ return vertical;} }

        [SerializeField] private float sensitivity;
        public float Sensitivity { get{ return  sensitivity;} }
    }
}
