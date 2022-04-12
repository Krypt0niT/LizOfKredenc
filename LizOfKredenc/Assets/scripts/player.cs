using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    Transform t;
    CharacterController chc;
    Controls controls;
    Vector2 move;
    Vector2 rotate;

    

    private void Awake()
    {

        chc = GetComponent<CharacterController>();
        t = GetComponent<Transform>();

        controls = new Controls();

        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;

        controls.Gameplay.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();

        controls.Gameplay.RB.performed += ctx => basicAttack();

    }
    void Start()
    {
        
    }

    void Update()
    {
        chc.Move(new Vector3(-move.x, 0, -move.y)* Time.deltaTime * 5);

        float angle = Mathf.Atan2(rotate.x, rotate.y) * Mathf.Rad2Deg; 
        t.rotation = Quaternion.Euler(new Vector3(0, 180 + angle, 0));


    }
    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }
    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
    void basicAttack()
    {
        print("utok");
    }

}
