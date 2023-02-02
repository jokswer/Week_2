namespace Player
{
    public class PlayerPresenter
    {
        private PlayerView _playerView;
        private PlayerModel _playerModel;
        private CoinsService _coinsService;

        public PlayerPresenter(PlayerView playerView, PlayerModel playerModel, CoinsService coinsService)
        {
            _playerView = playerView;
            _playerModel = playerModel;
            _coinsService = coinsService;
        }

        public void FixedUpdate()
        {
            _playerView.SetVelocity(_playerModel.VerticalSpeed, _playerModel.HorizontalSpeed);
            _playerView.SetRotation(_playerModel.RotationSpeed);
        }

        public void OnEnable()
        {
            _playerView.OnCoinTrigger += _coinsService.DestroyCoin;
            _playerModel.OnEnable();
        }

        public void OnDisable()
        {
            _playerView.OnCoinTrigger -= _coinsService.DestroyCoin;
            _playerModel.OnDisable();
        }
    }
}