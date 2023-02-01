using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 100f;
    
    private void Update()
    {
        transform.Rotate(Vector3.right, _rotationSpeed * Time.deltaTime);
    }
}