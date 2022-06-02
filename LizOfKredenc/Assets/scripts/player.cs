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

    GameObject audioManager;
    AudioManager sounds;
    AudioSource source;
    [SerializeField]
    GameObject PerkUI;
    PerkSelecter perkS;
    [SerializeField]
    ParticleSystem flash;
    [SerializeField]
    GameObject SumUI;
    summonerSellect Sum;



    [SerializeField]
    GameObject projectile;
    [SerializeField]
    GameObject charge;
    [SerializeField]
    GameObject blast;

    [SerializeField]
    Material playerMaterial;
   
    [SerializeField]
    private int playerIndex = 0;


    float casMana = 0;
    float casHealth = 0;

    float casHIT = 0;
    bool HIT = false;

    [HideInInspector]
    public float projectile_time = 0;
    [HideInInspector]
    public float flash_time = 0;
    [HideInInspector]
    public float speed_time = 0;
    float speed_lengh = 0;
    [HideInInspector]
    public float charge_time = 0;
    [HideInInspector]
    public float blast_time = 0;


    Vector2 MoveInputVector = Vector2.zero;
    Vector2 RotateInputVector = Vector2.zero;

    private void Awake()
    {

        chc = GetComponent<CharacterController>();
        t = GetComponent<Transform>();
        variables = manager.GetComponent<Manazer>();
        perkS = PerkUI.GetComponent<PerkSelecter>();
        Sum = SumUI.GetComponent<summonerSellect>();



        audioManager = GameObject.Find("AudioManager");
        sounds = audioManager.GetComponent<AudioManager>();
        source = audioManager.GetComponent<AudioSource>();



        projectile_time = variables.cooldown_projectile;
        flash_time = variables.cooldown_flash;
        charge_time = variables.cooldown_charge;
        blast_time = variables.cooldown_blast;
        speed_time = variables.cooldown_speed;



    }


    void Update()
    {
        if (variables.Game)
        {

            if (HIT)
            {
                if (this.name == "player1")
                {
                    playerMaterial.color = Color.red;

                }
                else
                {
                    playerMaterial.color = Color.blue;
                }
                casHIT += Time.deltaTime;
                if (casHIT > 0.15f)
                {
                    HIT = false;
                    casHIT = 0;
                }
            }
            else
            {
                playerMaterial.color = Color.white;
            }


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
            if (charge_time < variables.cooldown_charge)
            {
                charge_time += Time.deltaTime;

            }
            if (blast_time < variables.cooldown_blast)
            {
                blast_time += Time.deltaTime;

            }



            if (GetPlayerIndex() == 0)
            {
                //move
                chc.Move(new Vector3(-MoveInputVector.x, 0, -MoveInputVector.y) * Time.deltaTime * variables.player1_speed);



                

                if (!variables.player1_speedActive)
                {
                    if (variables.player1_perk_speed)
                    {
                        variables.player1_speed = 8;
                    }
                    else
                    {
                        variables.player1_speed = 5;
                    }
                }
                else
                {
                    if (variables.player1_perk_speed)
                    {
                        variables.player1_speed = 16;
                    }
                    else
                    {
                        variables.player1_speed = 10;
                    }
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





                if (!variables.player2_speedActive)
                {
                    if (variables.player2_perk_speed)
                    {
                        variables.player2_speed = 8;
                    }
                    else
                    {
                        variables.player2_speed = 5;
                    }
                }
                else
                {
                    if (variables.player2_perk_speed)
                    {
                        variables.player2_speed = 16;
                    }
                    else
                    {
                        variables.player2_speed = 10;
                    }
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
    }

    private void OnTriggerEnter(Collider other)
    {
        if (variables.Game)
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
                        variables.RoundEnd(this.name);
                    }
                    print("HIT\t to: " + this.name + "\tDMG: " + total_damage + "\theal: " + lifesteal);

                    Destroy(other.gameObject);
                    HIT = true;
                }
                if (other.name == "blastP2(Clone)")
                {
                    float critchance = 0;
                    if (variables.player2_perk_critchance1)
                    {
                        critchance = 20;
                    }
                    if (variables.player2_perk_critchance2)
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
                        bonusDMG = variables.player1_blastDMG / 10;
                    }
                    if (variables.player2_perk_bonusDMG2)
                    {
                        bonusDMG = variables.player1_blastDMG / 5;
                    }





                    float random = Random.Range(0, 100);
                    float CritBonusDMG = 0;
                    if (random <= critchance)
                    {
                        CritBonusDMG = variables.player1_blastDMG;
                    }



                    //---------------------
                    float total_damage = variables.player1_blastDMG + CritBonusDMG + bonusDMG;
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
                        variables.RoundEnd(this.name);
                    }
                    print("HIT\t to: " + this.name + "\tDMG: " + total_damage + "\theal: " + lifesteal);

                    Destroy(other.gameObject);
                    HIT = true;

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
                        variables.RoundEnd(this.name);

                    }
                    print("HIT\t to: " + this.name + "\tDMG: " + total_damage + "\theal: " + lifesteal);
                    Destroy(other.gameObject);
                    HIT = true;

                }
                if (other.name == "blastP1(Clone)")
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
                        bonusDMG = variables.player1_blastDMG / 10;
                    }
                    if (variables.player1_perk_bonusDMG2)
                    {
                        bonusDMG = variables.player1_blastDMG / 5;
                    }





                    float random = Random.Range(0, 100);
                    float CritBonusDMG = 0;
                    if (random <= critchance)
                    {
                        CritBonusDMG = variables.player1_blastDMG;
                    }



                    //---------------------
                    float total_damage = variables.player1_blastDMG + CritBonusDMG + bonusDMG;
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
                        variables.RoundEnd(this.name);

                    }
                    print("HIT\t to: " + this.name + "\tDMG: " + total_damage + "\theal: " + lifesteal);
                    Destroy(other.gameObject);
                    HIT = true;

                }






            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (this.name == "player2")
        {
            if (other.name == "ChargeP1(Clone)")
            {

                if (other.GetComponent<charge>().damage)
                {
                    float bonusDMG = 0;
                    if (variables.player1_perk_bonusDMG1)
                    {
                        bonusDMG = variables.player1_chargeDMG / 10;
                    }
                    if (variables.player1_perk_bonusDMG2)
                    {
                        bonusDMG = variables.player1_chargeDMG / 5;
                    }

                    //---------------------
                    float total_damage = variables.player1_chargeDMG + bonusDMG;
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
                        variables.RoundEnd(this.name);

                    }
                    print("HIT\t to: " + this.name + "\tDMG: " + total_damage + "\theal: " + lifesteal);
                    Destroy(other.gameObject);
                    HIT = true;

                }

            }
        }
        if (this.name == "player1")
        {
            if (other.name == "ChargeP2(Clone)")
            {

                if (other.GetComponent<charge>().damage)
                {
                    float bonusDMG = 0;
                    if (variables.player2_perk_bonusDMG1)
                    {
                        bonusDMG = variables.player2_chargeDMG / 10;
                    }
                    if (variables.player2_perk_bonusDMG2)
                    {
                        bonusDMG = variables.player2_chargeDMG / 5;
                    }

                    //---------------------
                    float total_damage = variables.player2_chargeDMG + bonusDMG;
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
                        variables.RoundEnd(this.name);

                    }
                    print("HIT\t to: " + this.name + "\tDMG: " + total_damage + "\theal: " + lifesteal);
                    Destroy(other.gameObject);
                    HIT = true;

                }

            }
        }

    }

    public void rightButton()
    {
        if (variables.Game)
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
                        source.PlayOneShot(sounds.projectile);
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
                        source.PlayOneShot(sounds.projectile);
                    }
                    projectile_time = 0;
                }
            }

        }

    }
    public void rightBackButton()
    {
        if (variables.Game)
        {
            if (GetPlayerIndex() == 0)
            {
                if (charge_time >= variables.cooldown_charge)
                {
                    if (variables.player1_mana >= variables.manaCost_charge)
                    {
                        Instantiate(charge, new Vector3(t.position.x, t.position.y, t.position.z), t.rotation);
                        charge_time = 0;
                        source.PlayOneShot(sounds.charge);
                        variables.player1_mana -= variables.manaCost_charge;
                    }
                        

                }
            }
            if (GetPlayerIndex() == 1)
            {
                if (charge_time >= variables.cooldown_charge)
                {
                    if (variables.player2_mana >= variables.manaCost_charge)
                    {
                        Instantiate(charge, new Vector3(t.position.x, t.position.y, t.position.z), t.rotation);
                        charge_time = 0;
                        source.PlayOneShot(sounds.charge);
                        variables.player2_mana -= variables.manaCost_charge;
                    }


                }
            }


        }
    }
    public void leftBackButton()
    {

        if (variables.Game)
        {




            if (flash_time >= variables.cooldown_flash)
            {


                //flash

                if (GetPlayerIndex() == 0)
                {
                    if (variables.player1_summonerSpell == "flash")
                    {



                        if (variables.player1_mana >= variables.manaCost_flash)
                        {


                            chc.enabled = false;
                            t.position += new Vector3(-MoveInputVector.x * 3, 0, -MoveInputVector.y * 3);
                            chc.enabled = true;
                            source.PlayOneShot(sounds.flash);



                            flash.transform.position = new Vector3(t.position.x, t.position.y, t.position.z);
                            flash.Play();

                            variables.player1_mana -= variables.manaCost_flash;
                            flash_time = 0;














                        }
                    }
                }

                else if (GetPlayerIndex() == 1)
                {
                    if (variables.player2_summonerSpell == "flash")
                    {

                        if (variables.player2_mana >= variables.manaCost_flash)
                        {



                            chc.enabled = false;
                            t.position += new Vector3(-MoveInputVector.x * 3, 0, -MoveInputVector.y * 3);
                            chc.enabled = true;
                            source.PlayOneShot(sounds.flash);


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
                            variables.player2_mana -= variables.manaCost_speed;
                        }
                    }
                }

            }
        }
    }
    public void leftButton()
    {

        if (variables.Game)
        {
            if (GetPlayerIndex() == 0)
            {

                if (blast_time >= variables.cooldown_blast)
                {
                    if (variables.player1_mana >= variables.manaCost_blast)
                    {
                        Instantiate(blast, new Vector3(t.position.x, t.position.y, t.position.z), t.rotation);
                        variables.player1_mana -= variables.manaCost_blast;
                        source.PlayOneShot(sounds.blast);
                    }
                    blast_time = 0;
                }
            }
            if (GetPlayerIndex() == 1)
            {

                if (blast_time >= variables.cooldown_blast)
                {
                    if (variables.player2_mana >= variables.manaCost_blast)
                    {
                        Instantiate(blast, new Vector3(t.position.x, t.position.y, t.position.z), t.rotation);
                        variables.player2_mana -= variables.manaCost_blast;
                        source.PlayOneShot(sounds.blast);
                    }
                    blast_time = 0;
                }
            }
        }

    }
    public void cross()
    {
        perkS.perkPick(GetPlayerIndex());
        Sum.sumPick(GetPlayerIndex());
        
    }
    public void circle()
    {
        if (variables.GameOver)
        {
            print("zmen senu");
        }
        //zmen scenu 
    }
    public void SetMoveInputVector(Vector2 direction)
    {
        MoveInputVector = direction;
    }
    public void SetRotateInputVector(Vector2 direction)
    {
        RotateInputVector = direction;
    }

    public void ArrowDirection(string direction)
    {
         perkS.IndexCalculator(direction, GetPlayerIndex());
         Sum.IndexCalculator(direction, GetPlayerIndex());



    }








    public int GetPlayerIndex()
    {
        return playerIndex;
    }
  

}
