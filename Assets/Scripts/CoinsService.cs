using TMPro;
using UnityEngine;

public class CoinsService : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _winMessage;

    private int _coinsCount;
    private CoinDestroy[] _coins;

    private void Awake()
    {
        _winMessage.SetActive(false);
        
        _coins = FindObjectsOfType<CoinDestroy>();
        _coinsCount = _coins.Length;

        ChangeScoreText();
    }

    private void OnCoinDestroy()
    {
        _coinsCount--;
        
        ChangeScoreText();
        CheckWinCondition();
    }

    private void CheckWinCondition()
    {
        if (_coinsCount == 0)
        {
            _winMessage.SetActive(true);
        }
    }

    private void ChangeScoreText()
    {
        _scoreText.text = $"Осталось собрать монет: {_coinsCount}";
    }

    private void OnEnable()
    {
        foreach (var coin in _coins)
        {
            coin.OnCoinDestroy += OnCoinDestroy;
        }
    }

    private void OnDisable()
    {
        foreach (var coin in _coins)
        {
            coin.OnCoinDestroy -= OnCoinDestroy;
        }
    }
}