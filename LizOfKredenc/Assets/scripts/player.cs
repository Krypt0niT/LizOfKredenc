using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

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
    [SerializeField]
    GameObject projectile;


    float casMana = 0;
    float casHealth = 0;

    float projectile_time = 0;

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

        controls.Gameplay.cross.performed += ctx => cross();

    }
    void Start()
    {
        
    }

    void Update()
    {
        chc.Move(new Vector3(-move.x, 0, -move.y)* Time.deltaTime * variables.player1_speed);

        float angle = Mathf.Atan2(rotate.x, rotate.y) * Mathf.Rad2Deg; 
        t.rotation = Quaternion.Euler(new Vector3(0, 180 + angle, 0));

        projectile_time += Time.deltaTime;

        if (name == "player1")
        {
            casHealth += Time.deltaTime;
            if (casHealth >= (1 / variables.player1_healthRegen))
            {
                if (variables.player1_health + 1 >= variables.player1_Maxhealth)
                {
                    variables.player1_health = variables.player1_Maxhealth;
                }
                else
                {
                    variables.player1_health++;
                }
                casHealth = 0;
            }


            casMana += Time.deltaTime;
            if (casMana >= (1 / variables.player1_manaRegen))
            {
                if (variables.player1_mana + 1 >= variables.player1_Maxmana)
                {
                    variables.player1_mana = variables.player1_Maxmana;
                }
                else
                {
                    variables.player1_mana++;
                }
                casMana = 0;
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
        if (projectile_time >= variables.cooldown_projectile)
        {
            if (variables.player1_mana >= variables.manaCost_projectile)
            {
                Instantiate(projectile, new Vector3(t.position.x, t.position.y, t.position.z), t.rotation);
                variables.player1_mana -= variables.manaCost_projectile;
            }
            projectile_time = 0;
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
    void cross()
    {
        if (variables.player1_health > 0)
        {
            variables.player1_health -= 100f;
        }
    }


}
