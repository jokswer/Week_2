using Player;
using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    
    [Header("Player Config")] 
    [SerializeField] private Transform _playerStartPoint;
    [SerializeField] private float _playerSpeed = 5f;

    private PlayerPresenter _playerPresenter;

    private void Start()
    {
        var playerInput = new PlayerModel(_playerSpeed);
        var playerObject = Instantiate(_player, _playerStartPoint.position, Quaternion.identity);
        var playerView = playerObject.GetComponent<PlayerView>();

        _playerPresenter = new PlayerPresenter(playerView, playerInput);
    }

    private void Update()
    {
        _playerPresenter.Update();
    }

    private void FixedUpdate()
    {
        _playerPresenter.FixedUpdate();
    }
}