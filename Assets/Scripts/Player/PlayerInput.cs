using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerInput
    {
        private InputActions _inputActions;

        public float Rotation => _inputActions.Player.Rotate.ReadValue<float>();
        public bool IsBoost => _inputActions.Player.Boost.phase == InputActionPhase.Performed;
        public Vector2 Move => _inputActions.Player.Move.ReadValue<Vector2>();

        public PlayerInput()
        {
            _inputActions = new InputActions();
        }

        public void Enable()
        {
            _inputActions.Player.Enable();
        }

        public void Disable()
        {
            _inputActions.Player.Disable();
        }
    }
}