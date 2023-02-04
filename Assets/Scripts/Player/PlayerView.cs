using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerView : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        /// <summary>
        /// Use only in FixedUpdate
        /// </summary>
        /// <param name="vertical"></param>
        /// <param name="horizontal"></param>
        public void SetVelocity(float vertical, float horizontal)
        {
            var velocity = new Vector3(horizontal, _rigidbody.velocity.y, vertical);
            var worldVelocity = transform.TransformVector(velocity);

            _rigidbody.velocity = worldVelocity;
        }

        /// <summary>
        /// Use only in FixedUpdate
        /// </summary>
        /// <param name="rotation"></param>
        public void SetRotation(float rotation)
        {
            _rigidbody.angularVelocity = new Vector3(0f, rotation, 0f);
        }
    }
}