using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class player : MonoBehaviour
{
    Transform t;
    CharacterController chc;

    [SerializeField]
    GameObject manager;
    Manazer variables;
    [SerializeField]
    ParticleSystem flash;

    [SerializeField] 
    AudioSource flash_source;
    [SerializeField]
    AudioClip flash_clip;

    [SerializeField]
    GameObject projectile;
    [SerializeField]
    GameObject playerCollisionTester;
    [SerializeField]
    private int playerIndex = 0;


    float casMana = 0;
    float casHealth = 0;

    [HideInInspector]
    public float projectile_time = 0;
    [HideInInspector]
    public float flash_time = 0;
    [HideInInspector]
    public float speed_time = 0;
    float speed_lengh = 0;

    Vector2 MoveInputVector = Vector2.zero;
    Vector2 RotateInputVector = Vector2.zero;

    private void Awake()
    {

        chc = GetComponent<CharacterController>();
        t = GetComponent<Transform>();
        variables = manager.GetComponent<Manazer>();

        



        


    }
    void Start()
    {
        
    }

    void Update()
    {
        if (RotateInputVector.x == 0 && RotateInputVector.y == 0)
        {
            t.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else
        {
            float angle = Mathf.Atan2(RotateInputVector.x, RotateInputVector.y) * Mathf.Rad2Deg;
            t.rotation = Quaternion.Euler(new Vector3(0, 180 + angle, 0));
        }
        
        if (projectile_time < variables.cooldown_projectile)
        {
            projectile_time += Time.deltaTime;
        }
        if (flash_time < variables.cooldown_flash)
        {
            flash_time += Time.deltaTime;

        }
        if (speed_time < variables.cooldown_speed)
        {
            speed_time += Time.deltaTime;

        }



        if (GetPlayerIndex() == 0)
        {
            //move
            chc.Move(new Vector3(-MoveInputVector.x, 0, -MoveInputVector.y) * Time.deltaTime * variables.player1_speed);



            if (variables.player1_perk_HealthIncrise1)
            {
                variables.player1_Maxhealth = 1250;
            }
            if (variables.player1_perk_HealthIncrise2)
            {
                variables.player1_Maxhealth = 1500;
            }
            if (!variables.player1_perk_HealthIncrise1 && !variables.player1_perk_HealthIncrise2)
            {
                variables.player1_Maxhealth = 1000;
            }
            if (variables.player1_health > variables.player1_Maxhealth)
            {
                variables.player1_health = variables.player1_Maxhealth; 
            }
            



            if (variables.player1_speedActive)
            {
                
                speed_lengh += Time.deltaTime;
                if (speed_lengh >= variables.lengh_speed)
                {
                    variables.player1_speedActive = false;
                    variables.player1_speed = variables.player1_speed / 2;
                    speed_lengh = 0;
                }

            }
            if (variables.player2_speedActive)
            {

                speed_lengh += Time.deltaTime;
                if (speed_lengh >= variables.lengh_speed)
                {
                    variables.player2_speedActive = false;
                    variables.player2_speed = variables.player2_speed / 2;
                    speed_lengh = 0;
                }

            }


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
            //move
            chc.Move(new Vector3(-MoveInputVector.x, 0, -MoveInputVector.y) * Time.deltaTime * variables.player2_speed);


            if (variables.player2_perk_HealthIncrise1)
            {
                variables.player2_Maxhealth = 1250;
            }
            if (variables.player2_perk_HealthIncrise2)
            {
                variables.player2_Maxhealth = 1500;
            }
            if (!variables.player2_perk_HealthIncrise1 && !variables.player2_perk_HealthIncrise2)
            {
                variables.player2_Maxhealth = 1000;
            }
            if (variables.player2_health > variables.player2_Maxhealth)
            {
                variables.player2_health = variables.player2_Maxhealth;
            }





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

    private void OnTriggerEnter(Collider other)
    {
        
        if (this.name == "player1")
        {
            if (other.name == "ProjectilePlayer2(Clone)")
            {
                float critchance = 0;
                if (variables.player2_perk_critchance1)
                {
                    critchance = 20;
                }
                if(variables.player2_perk_critchance2)
                {
                    critchance = 30;
                }
                if (variables.player2_perk_critchance3)
                {
                    critchance = 45;
                }
                if (!variables.player2_perk_critchance1 && !variables.player2_perk_critchance2 && !variables.player2_perk_critchance1)
                {
                    critchance = 10;
                }



                float bonusDMG = 0;
                if (variables.player2_perk_bonusDMG1)
                {
                    bonusDMG = variables.player2_projectileDMG / 10;
                }
                if (variables.player2_perk_bonusDMG2)
                {
                    bonusDMG = variables.player2_projectileDMG / 5;
                }

                

                

                float random = Random.Range(0, 100);
                float CritBonusDMG = 0;
                if (random <= critchance)
                {
                    CritBonusDMG = variables.player2_projectileDMG ;
                }



                //---------------------
                float total_damage = variables.player2_projectileDMG + CritBonusDMG + bonusDMG;
                //-----------------------

                float lifesteal = 0;
                if (variables.player2_perk_lifesteal1)
                {
                    lifesteal = total_damage / 3;
                }
                if (variables.player2_perk_lifesteal2)
                {
                    lifesteal = total_damage / 2;
                }


                if (variables.player1_health >= total_damage)
                {
                    variables.player1_health -= total_damage;



                    if (variables.player2_health <= variables.player2_Maxhealth - lifesteal)
                    {
                        variables.player2_health += lifesteal;
                    }
                }
                else
                {
                    variables.player1_health = 0;
                }
                print("HIT\t to: " + this.name + "\tDMG: " + total_damage + "\theal: " + lifesteal);

                Destroy(other.gameObject);
            }
        }
        if (this.name == "player2")
        {
            if (other.name == "ProjectilePlayer1(Clone)")
            {
                float critchance = 0;
                if (variables.player1_perk_critchance1)
                {
                    critchance = 20;
                }
                if (variables.player1_perk_critchance2)
                {
                    critchance = 30;
                }
                if (variables.player1_perk_critchance3)
                {
                    critchance = 45;
                }
                if (!variables.player1_perk_critchance1 && !variables.player1_perk_critchance2 && !variables.player1_perk_critchance1)
                {
                    critchance = 10;
                }



                float bonusDMG = 0;
                if (variables.player1_perk_bonusDMG1)
                {
                    bonusDMG = variables.player1_projectileDMG / 10;
                }
                if (variables.player1_perk_bonusDMG2)
                {
                    bonusDMG = variables.player1_projectileDMG / 5;
                }





                float random = Random.Range(0, 100);
                float CritBonusDMG = 0;
                if (random <= critchance)
                {
                    CritBonusDMG = variables.player1_projectileDMG;
                }



                //---------------------
                float total_damage = variables.player1_projectileDMG + CritBonusDMG + bonusDMG;
                //-----------------------

                float lifesteal = 0;
                if (variables.player1_perk_lifesteal1)
                {
                    lifesteal = total_damage / 3;
                }
                if (variables.player1_perk_lifesteal2)
                {
                    lifesteal = total_damage / 2;
                }


                if (variables.player2_health >= total_damage)
                {
                    variables.player2_health -= total_damage;



                    if (variables.player1_health <= variables.player1_Maxhealth - lifesteal)
                    {
                        variables.player1_health += lifesteal;
                    }
                }
                else
                {
                    variables.player2_health = 0;
                }
                print("HIT\t to: " + this.name + "\tDMG: " + total_damage + "\theal: " + lifesteal);
                Destroy(other.gameObject);
            }
        }
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
                    projectile.name = "ProjectilePlayer1";
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
                    projectile.name = "ProjectilePlayer2";
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
        
        

        
            if (flash_time >= variables.cooldown_flash)
            {


                //flash
                
                if (GetPlayerIndex()==0)
                {
                    if (variables.player1_summonerSpell == "flash")
                    {

                

                        if (variables.player1_mana >= variables.manaCost_flash) 
                        {

                        Vector3 novaPozicia = new Vector3(-MoveInputVector.x * 3, 0, -MoveInputVector.y * 3);
                        



                        if (!Physics.Raycast(transform.position, novaPozicia, 10))
                        {
                            chc.enabled = false;
                            t.position += new Vector3(-MoveInputVector.x * 3, 0, -MoveInputVector.y * 3);
                            chc.enabled = true;
                            flash_source.PlayOneShot(flash_clip);



                            flash.transform.position = new Vector3(t.position.x, t.position.y, t.position.z);
                            flash.Play();

                            variables.player1_mana -= variables.manaCost_flash;
                            flash_time = 0;
                        }






                        
                        





                    }
                }
                }

                else if(GetPlayerIndex() == 1)
                {
                    if (variables.player2_summonerSpell == "flash")
                    {



                        Vector3 novaPozicia = new Vector3(-MoveInputVector.x * 3, 0, -MoveInputVector.y * 3);

                        if (!Physics.Raycast(transform.position, novaPozicia, 10))
                        {
                            chc.enabled = false;
                            t.position += new Vector3(-MoveInputVector.x * 3, 0, -MoveInputVector.y * 3);
                            chc.enabled = true;
                            flash_source.PlayOneShot(flash_clip);

                            flash.transform.position = new Vector3(t.position.x, t.position.y, t.position.z);
                            flash.Play();

                            variables.player2_mana -= variables.manaCost_flash;
                            flash_time = 0;
                        }
                    }
                }
            }
        


         
        
            if (GetPlayerIndex() == 0)
            {

                if (variables.player1_summonerSpell == "speed")
                {

                


                    if (speed_time >= variables.cooldown_speed)
                    {
                        if (variables.player1_mana >= variables.manaCost_speed)
                        {

                    
                            speed_time = 0;
                            variables.player1_speedActive = true;
                            variables.player1_speed = variables.player1_speed * 2;
                            variables.player1_mana -= variables.manaCost_speed;
                        }
                    }
                }

            }
            if (GetPlayerIndex() == 1)
            {

                if (variables.player2_summonerSpell == "speed")
                {

            


                    if (speed_time >= variables.cooldown_speed)
                    {
                        if (variables.player2_mana >= variables.manaCost_speed)
                        {


                            speed_time = 0;
                            variables.player2_speedActive = true;
                            variables.player2_speed = variables.player2_speed * 2;
                            variables.player2_mana -= variables.manaCost_speed;
                        }
                    }
                }

            }

        
    }
    public void cross()
    {
        if (GetPlayerIndex() == 0)
        {
            if (variables.player1_health > 100)
            {
                variables.player1_health -= 100f;
            }
        }
        if (GetPlayerIndex() == 1)
        {
            if (variables.player2_health > 100)
            {
                variables.player2_health -= 100f;
            }
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
