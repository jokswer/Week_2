using Player;
using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private CameraMovement _cameraMovement;
    
    [Header("Player Config")] 
    [SerializeField] private Transform _playerStartPoint;
    [SerializeField] private float _playerSpeed = 5f;

    private PlayerPresenter _playerPresenter;
    private Transform _playerTransform;

    private void Start()
    {
        var playerModel = new PlayerModel(_playerSpeed);
        var playerObject = Instantiate(_player, _playerStartPoint.position, Quaternion.identity);
        var playerView = playerObject.GetComponent<PlayerView>();

        _playerPresenter = new PlayerPresenter(playerView, playerModel);
        _playerTransform = playerObject.GetComponent<Transform>();
    }

    private void Update()
    {
        _playerPresenter.Update();
    }

    private void FixedUpdate()
    {
        _playerPresenter.FixedUpdate();
    }

    private void LateUpdate()
    {
        _cameraMovement.SetPosition(_playerTransform.position);
    }
}