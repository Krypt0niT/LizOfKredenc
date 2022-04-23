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
        if (Player != null)
            Player.SetMoveInputVector(context.ReadValue<Vector2>());
    }
    public void OnRotate(CallbackContext context)
    {
        if (Player != null)
            Player.SetRotateInputVector(context.ReadValue<Vector2>());
    }
    public void OnRB(CallbackContext context)
    {
        if (Player != null)
            Player.rightButton();
    }
    public void OnLB(CallbackContext context)
    {
        if (Player != null)
            Player.leftButton();
    }
    public void OnCross(CallbackContext context)
    {
        if (Player != null)
            Player.cross();
    }
}
