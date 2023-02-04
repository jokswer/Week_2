using System;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    public event Action OnCoinDestroy;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            OnCoinDestroy?.Invoke();
        }
    }
}