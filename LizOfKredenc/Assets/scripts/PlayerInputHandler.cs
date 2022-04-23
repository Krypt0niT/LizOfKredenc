using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
using System.Linq;

public class PlayerInputHandler : MonoBehaviour
{

    private PlayerInput playerInput;
    private player Player;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var players = FindObjectsOfType<player>();
        var index = playerInput.playerIndex;
        Player = players.FirstOrDefault(p => p.GetPlayerIndex() == index);
    }

    public void OnMove(CallbackContext context)
    {
        Player.SetMoveInputVector(context.ReadValue<Vector2>());
    }
    public void OnRotate(CallbackContext context)
    {
        Player.SetRotateInputVector(context.ReadValue<Vector2>());
    }
    public void OnRB(CallbackContext context)
    {
        Player.rightButton();
    }
    public void OnLB(CallbackContext context)
    {
        Player.leftButton();
    }
}
