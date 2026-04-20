using Unity.Netcode;
using UnityEngine;
using System;
using Unity.Services.Authentication;
using UnityEngine.InputSystem;

public class PlayerController : NetworkBehaviour
{
    [SerializeField] private PlayerINput playerInput;
    [SerializeField] private AgentMover agentMover;

    private void Update()
    {
        if (IsOwner == false)
        {
            return;
        }
        Vector2 movementInput = playerInput.MovementInput;
        agentMover.Move(movementInput);
    }
}
