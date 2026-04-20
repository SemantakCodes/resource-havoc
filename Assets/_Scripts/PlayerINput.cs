using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerINput : NetworkBehaviour
{
    [SerializeField]
    private InputActionReference movementReference;

    public Vector2 MovementInput { get; private set; }
    public event Action OnPickUpPressed;
    public event Action OnInteractPressed;

    private Vector2 rawInput;
    [SerializeField] private float smoothTime = 0.1f;

    private void Update()
    {
        if (!IsOwner)
        {
            return;
        }

        rawInput = movementReference.action.ReadValue<Vector2>();
        MovementInput = Vector2.MoveTowards(MovementInput, rawInput, Time.deltaTime / smoothTime);

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            OnPickUpPressed?.Invoke();
        }
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            OnInteractPressed?.Invoke();
        }
    }
}
