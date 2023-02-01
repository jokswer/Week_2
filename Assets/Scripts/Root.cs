using Player;
using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _cameraTransform;
    
    [Header("Player Config")] 
    [SerializeField] private Transform _startPoint;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _rotationSpeed = 10f;
    [SerializeField] private Vector3 _cameraOffset;

    private PlayerPresenter _playerPresenter;

    private void Start()
    {
        var playerObject = Instantiate(_player, _startPoint.position, Quaternion.identity);
        var playerView = playerObject.GetComponent<PlayerView>();

        var playerModel = new PlayerModel(_speed, _rotationSpeed);
        _playerPresenter = new PlayerPresenter(playerView, playerModel);
        
        ConfigCamera(playerObject);
    }

    private void FixedUpdate()
    {
        _playerPresenter.FixedUpdate();
    }

    private void ConfigCamera(GameObject player)
    {
        _cameraTransform.parent = player.transform;
        _cameraTransform.position = player.transform.position + _cameraOffset;
    }
}