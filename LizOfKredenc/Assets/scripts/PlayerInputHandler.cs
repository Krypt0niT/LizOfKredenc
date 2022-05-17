using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
using System.Linq;

public class PlayerInputHandler : MonoBehaviour
{

    PlayerInput playerInput;
    player Player;
    Manazer variables;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var players = FindObjectsOfType<player>();
        
        variables = GameObject.Find("Manager").GetComponent<Manazer>();





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
        {
            if (context.started)
            {
                Player.rightButton();
            }

        }
        
    }
    public void OnLB(CallbackContext context)
    {
        if (Player != null)
        {
            if (context.started)
            {
                Player.leftButton();
            }
        }
           
    }
    public void OnCross(CallbackContext context)
    {
        if (Player != null)
        {
            if (context.started)
            {
                Player.cross();
            }
        }
            
    }
    public void OnRBB(CallbackContext context)
    {
        if (Player != null)
        {
            if (context.started)
            {
                Player.rightBackButton();

            }
        }
    }
    public void OnUP(CallbackContext context)
    {
        if (Player != null)
        {
            if (context.started)
            {
                Player.ArrowDirection("UP");
            }
        }
    }
    public void OnRIGHT(CallbackContext context)
    {
        if (Player != null)
        {
            if (context.started)
            {

                Player.ArrowDirection("RIGHT");



            }
        }
    }
    public void OnDOWN(CallbackContext context)
    {
        if (Player != null)
        {
            if (context.started)
            {

                Player.ArrowDirection("DOWN");


            }
        }
    }
    public void OnLEFT(CallbackContext context)
    {
        if (Player != null)
        {
            if (context.started)
            {
                

                Player.ArrowDirection("LEFT");


            }
        }
    }
}
