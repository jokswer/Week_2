using Player;
using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private CoinsService _coinsService;
    
    [Header("Player Config")] 
    [SerializeField] private Transform _startPoint;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _rotationSpeed = 10f;
    [SerializeField] private int _boostSpeed = 3;
    [SerializeField] private Vector3 _cameraOffset;

    private PlayerPresenter _playerPresenter;

    private void Awake()
    {
        var playerObject = Instantiate(_player, _startPoint.position, Quaternion.identity);
        var playerView = playerObject.GetComponent<PlayerView>();

        var playerModel = new PlayerModel(_speed, _rotationSpeed, _boostSpeed);
        _playerPresenter = new PlayerPresenter(playerView, playerModel, _coinsService);
        
        ConfigCamera(playerObject);
    }

    private void FixedUpdate()
    {
        _playerPresenter.FixedUpdate();
    }

    private void OnEnable()
    {
        _playerPresenter.OnEnable();
    }

    private void OnDisable()
    {
        _playerPresenter.OnDisable();
    }

    private void ConfigCamera(GameObject player)
    {
        _cameraTransform.parent = player.transform;
        _cameraTransform.position = player.transform.position + _cameraOffset;
    }
}