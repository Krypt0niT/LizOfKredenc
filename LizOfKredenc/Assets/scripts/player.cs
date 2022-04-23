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
    [SerializeField]
    private int playerIndex = 0;


    float casMana = 0;
    float casHealth = 0;

    float projectile_time = 0;

    Vector2 MoveInputVector = Vector2.zero;
    Vector2 RotateInputVector = Vector2.zero;

    private void Awake()
    {

        chc = GetComponent<CharacterController>();
        t = GetComponent<Transform>();
        variables = manager.GetComponent<Manazer>();
        controls = new Controls();

        



        controls.Gameplay.RBB.performed += ctx => rightBackButton();

        controls.Gameplay.cross.performed += ctx => cross();

    }
    void Start()
    {
        
    }

    void Update()
    {
        chc.Move(new Vector3(-MoveInputVector.x, 0, -MoveInputVector.y) * Time.deltaTime * variables.player1_speed);
        float angle = Mathf.Atan2(RotateInputVector.x, RotateInputVector.y) * Mathf.Rad2Deg; 
        t.rotation = Quaternion.Euler(new Vector3(0, 180 + angle, 0));

        projectile_time += Time.deltaTime;

        if (GetPlayerIndex() == 0)
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
        else if (GetPlayerIndex() == 1)
        {
            casHealth += Time.deltaTime;
            if (casHealth >= (1 / variables.player2_healthRegen))
            {
                if (variables.player2_health + 1 >= variables.player2_Maxhealth)
                {
                    variables.player2_health = variables.player2_Maxhealth;
                }
                else
                {
                    variables.player2_health++;
                }
                casHealth = 0;
            }


            casMana += Time.deltaTime;
            if (casMana >= (1 / variables.player2_manaRegen))
            {
                if (variables.player2_mana + 1 >= variables.player2_Maxmana)
                {
                    variables.player2_mana = variables.player2_Maxmana;
                }
                else
                {
                    variables.player2_mana++;
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
    public void rightButton()
    {
        if (GetPlayerIndex() == 0)
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
        else if (GetPlayerIndex() == 1)
        {

            if (projectile_time >= variables.cooldown_projectile)
            {
                if (variables.player2_mana >= variables.manaCost_projectile)
                {
                    Instantiate(projectile, new Vector3(t.position.x, t.position.y, t.position.z), t.rotation);
                    variables.player2_mana -= variables.manaCost_projectile;
                }
                projectile_time = 0;
            }
        }



    }
    public void rightBackButton()
    {

    }
    public void leftButton()
    {
        //if ability selected:....
        print(GetPlayerIndex());

        //flash
        if (GetPlayerIndex()==0)
        {

            if (variables.player1_mana >= variables.manaCost_flash) 
            { 
                chc.Move(new Vector3(-MoveInputVector.x * 3, 0, -MoveInputVector.y * 3));
                flash.transform.position = new Vector3(t.position.x, t.position.y, t.position.z);
                flash.Play();
            
                variables.player1_mana -= variables.manaCost_flash;
                print("mana minus");
            }
        }
        else if(GetPlayerIndex() == 1)
        {

            if (variables.player2_mana >= variables.manaCost_flash)
            {
                chc.Move(new Vector3(-MoveInputVector.x * 3, 0, -MoveInputVector.y * 3));
                flash.transform.position = new Vector3(t.position.x, t.position.y, t.position.z);
                flash.Play();

                variables.player2_mana -= variables.manaCost_flash;
            }
        }

    }
    public void cross()
    {
        if (variables.player1_health > 0)
        {
            variables.player1_health -= 100f;
        }
    }
    public void SetMoveInputVector(Vector2 direction)
    {
        MoveInputVector = direction;
       
       
    }
    public void SetRotateInputVector(Vector2 direction)
    {
        RotateInputVector = direction;


    }













    public int GetPlayerIndex()
    {
        return playerIndex;
    }


}
