using UnityEngine;

namespace Player
{
    public class PlayerPresenter
    {
        private PlayerView _playerView;
        private PlayerModel _playerModel;
        
        public PlayerPresenter(PlayerView playerView, PlayerModel playerModel)
        {
            _playerView = playerView;
            _playerModel = playerModel;
        }

        public void Update()
        {
            Debug.Log(_playerModel.HorizontalSpeed);
            Debug.Log(_playerModel.VerticalSpeed);
        }

        public void FixedUpdate()
        {
            _playerView.SetVelocity(_playerModel.VerticalSpeed, _playerModel.HorizontalSpeed);
        }
    }
}