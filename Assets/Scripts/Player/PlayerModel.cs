using UnityEngine;

namespace Player
{
    public class PlayerModel
    {
        private float _speed;

        public float HorizontalSpeed => Input.GetAxis("Horizontal") * _speed;
        public float VerticalSpeed => Input.GetAxis("Vertical") * _speed;

        public PlayerModel(float speed)
        {
            _speed = speed;
        }
    }
}