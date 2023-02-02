using TMPro;
using UnityEngine;

public class CoinsService : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _winMessage;
    
    private int _coinsCount;

    private void Start()
    {
        _coinsCount = FindObjectsOfType<CoinRotation>().Length;
        _winMessage.SetActive(false);
        ChangeScoreText();
    }

    public void DestroyCoin(GameObject coin)
    {
        Destroy(coin);
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
}