using UnityEngine;

namespace Player
{
    public class PlayerModel
    {
        private float _speed;
        private float _rotationSpeed;
        private int _boostSpeed;

        //TODO: change to InputSystem and take out
        public float HorizontalSpeed => Input.GetAxis("Horizontal") * _speed * BoostSpeed;
        public float VerticalSpeed => Input.GetAxis("Vertical") * _speed * BoostSpeed;
        public float RotationSpeed => Input.GetAxis("Mouse X") * _rotationSpeed;
        public int BoostSpeed => Input.GetKey(KeyCode.LeftShift) ? _boostSpeed : 1;

        public PlayerModel(float speed, float rotationSpeed, int boostSpeed)
        {
            _speed = speed;
            _rotationSpeed = rotationSpeed;
            _boostSpeed = boostSpeed;
        }
    }
}