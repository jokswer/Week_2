namespace Player
{
    public class PlayerModel
    {
        private PlayerInput _playerInput;
        private float _speed;
        private float _rotationSpeed;
        private int _boostSpeed;

        public float HorizontalSpeed => _playerInput.Move.x * _speed * BoostSpeed;
        public float VerticalSpeed => _playerInput.Move.y * _speed * BoostSpeed;
        public float RotationSpeed => _playerInput.Rotation * _rotationSpeed;
        public int BoostSpeed => _playerInput.IsBoost ? _boostSpeed : 1;

        public PlayerModel(float speed, float rotationSpeed, int boostSpeed)
        {
            _playerInput = new PlayerInput();
            _speed = speed;
            _rotationSpeed = rotationSpeed;
            _boostSpeed = boostSpeed;
        }
        
        public void OnEnable()
        {
            _playerInput.Enable();
        }

        public void OnDisable()
        {
            _playerInput.Disable();
        }
    }
}