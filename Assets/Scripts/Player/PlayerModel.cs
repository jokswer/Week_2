using UnityEngine;

namespace Player
{
    public class PlayerModel
    {
        private float _speed;
        private float _rotationSpeed;

        public float HorizontalSpeed => Input.GetAxis("Horizontal") * _speed;
        public float VerticalSpeed => Input.GetAxis("Vertical") * _speed;
        public float RotationSpeed => Input.GetAxis("Mouse X") * _rotationSpeed;

        public PlayerModel(float speed, float rotationSpeed)
        {
            _speed = speed;
            _rotationSpeed = rotationSpeed;
        }
    }
}