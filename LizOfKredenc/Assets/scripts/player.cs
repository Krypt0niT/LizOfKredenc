using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    CharacterController chc;
    Controls controls;
    Vector2 move;
    Vector2 rotate;

    private void Awake()
    {
        chc = GetComponent<CharacterController>();


        controls = new Controls();

        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;

        controls.Gameplay.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.Gameplay.Rotate.canceled += ctx => rotate = Vector2.zero;

    }
    void Start()
    {
        
    }

    void Update()
    {
        chc.Move(new Vector3(move.x, 0, move.y)* Time.deltaTime * 5);
        print(move);
        transform.Rotate(new Vector3(0,rotate.y,0)* 10);
    }
    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }
    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
