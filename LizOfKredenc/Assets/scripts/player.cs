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
    [SerializeField]
    GameObject manager;
    Manazer variables;
    [SerializeField]
    ParticleSystem flash;

    float cas = 0;

    private void Awake()
    {

        chc = GetComponent<CharacterController>();
        t = GetComponent<Transform>();
        variables = manager.GetComponent<Manazer>();
        controls = new Controls();

        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;

        controls.Gameplay.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();

        controls.Gameplay.RB.performed += ctx => rightButton();

        controls.Gameplay.LB.performed += ctx => leftButton();

    }
    void Start()
    {
        
    }

    void Update()
    {
        chc.Move(new Vector3(-move.x, 0, -move.y)* Time.deltaTime * variables.player1_speed);

        float angle = Mathf.Atan2(rotate.x, rotate.y) * Mathf.Rad2Deg; 
        t.rotation = Quaternion.Euler(new Vector3(0, 180 + angle, 0));
        if (name == "player1")
        {
            if(variables.player1_mana < variables.player1_Maxmana)
            {
                cas += Time.deltaTime;
                if (cas >= 1)
                {
                    cas = 0;
                    if (variables.player1_mana + variables.player1_manaRegen > variables.player1_Maxmana)
                    {
                        variables.player1_mana = variables.player1_Maxmana;
                    }
                    else
                    {
                        variables.player1_mana += variables.player1_manaRegen;
                    }
                }
            }
        }


    }
    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }
    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
    void rightButton()
    {
        if (variables.player1_health > 0)
        {
            variables.player1_health -= 100f;
        }
        
    }
    void leftButton()
    {
        //if ability selected:....

        //flash
        if (variables.player1_mana >= variables.manaCost_flash) 
        { 
            chc.Move(new Vector3(-move.x * 3, 0, -move.y * 3));
            flash.transform.position = new Vector3(t.position.x, t.position.y, t.position.z);
            flash.Play();
            variables.player1_mana -= variables.manaCost_flash;
        }

    }


}
