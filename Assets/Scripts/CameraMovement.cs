using UnityEngine;

[RequireComponent(typeof(Transform))]
public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _cameraTransform;

    private readonly Vector3 _cameraOffset = new Vector3(0, 1.20f, -3.60f);

    private void Start()
    {
        _cameraTransform = GetComponent<Transform>();
    }

    /// <summary>
    /// Recommended use in LateUpdate
    /// </summary>
    /// <param name="playerPosition"></param>
    public void SetPosition(Vector3 playerPosition)
    {
        var nextPosition = playerPosition + _cameraOffset;
        _cameraTransform.position = nextPosition;
    }
}