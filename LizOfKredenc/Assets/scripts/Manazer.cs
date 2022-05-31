using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manazer : MonoBehaviour
{
    public float player1_Maxhealth = 1000;
    public float player1_health = 1000;
    public float player1_healthRegen = 100;

    
    public float player1_Maxmana = 250;
    public float player1_mana = 250;
    public float player1_manaRegen = 50;

    public float player1_speed = 5;
    public float player1_projectileDMG = 200;
    public float player1_chargeDMG = 350;


    public string player1_summonerSpell = "speed";
    public bool player1_speedActive = false;
    //perky
    public bool player1_perk_lifesteal1 = false;
    public bool player1_perk_lifesteal2 = false;
    public bool player1_perk_critchance1 = false;
    public bool player1_perk_critchance2 = false;
    public bool player1_perk_critchance3 = false;
    public bool player1_perk_bonusDMG1 = false;
    public bool player1_perk_bonusDMG2 = false;
    public bool player1_perk_speed = false;
    public bool player1_perk_HealthIncrise1 = false;
    public bool player1_perk_HealthIncrise2 = false;

    [HideInInspector] public bool player1_perk_lifesteal2_avaiable = false;
    [HideInInspector] public bool player1_perk_critchance2_avaiable = false;
    [HideInInspector] public bool player1_perk_critchance3_avaiable = false;
    [HideInInspector] public bool player1_perk_bonusDMG2_avaiable = false;
    [HideInInspector] public bool player1_perk_HealthIncrise2_avaiable = false;




    public float player2_Maxhealth = 1000;
    public float player2_health = 1000;
    public float player2_healthRegen = 100;

    
    public float player2_Maxmana = 250;
    public float player2_mana = 250;
    public float player2_manaRegen = 50;

    public float player2_speed = 5;
    public float player2_projectileDMG = 200;
    public float player2_chargeDMG = 350;


    public string player2_summonerSpell = "flash";
    public bool player2_speedActive = false;
    //perky
    public bool player2_perk_lifesteal1 = false;
    public bool player2_perk_lifesteal2 = false;
    public bool player2_perk_critchance1 = false;
    public bool player2_perk_critchance2 = false;
    public bool player2_perk_critchance3 = false;
    public bool player2_perk_bonusDMG1 = false;
    public bool player2_perk_bonusDMG2 = false;
    public bool player2_perk_speed = false;
    public bool player2_perk_HealthIncrise1 = false;
    public bool player2_perk_HealthIncrise2 = false;

    [HideInInspector] public bool player2_perk_lifesteal2_avaiable = false;
    [HideInInspector] public bool player2_perk_critchance2_avaiable = false;
    [HideInInspector] public bool player2_perk_critchance3_avaiable = false;
    [HideInInspector] public bool player2_perk_bonusDMG2_avaiable = false;
    [HideInInspector] public bool player2_perk_HealthIncrise2_avaiable = false;








    //vseobecne pravidla hry
    public float manaCost_flash = 100;
    public float cooldown_flash = 0.5f;

    public float manaCost_projectile = 20;
    public float cooldown_projectile = 3;

    public float manaCost_blast = 50;
    public float cooldown_blast = 3;


    public float cooldown_charge = 7;
    public float manaCost_charge = 50;


    
    public float manaCost_speed = 100;
    public float cooldown_speed = 10;
    public float lengh_speed = 5;

    public int player1_SCORE = 0;
    public int player2_SCORE = 0;

    public bool player1_perkSelected = false;
    public bool player2_perkSelected = false;


    public bool Game = false;








    [SerializeField]
    GameObject Player1;
    [SerializeField]
    GameObject Player2;
    [SerializeField]
    GameObject Player1HB;
    [SerializeField]
    GameObject Player2HB;
    [SerializeField]
    GameObject GameUI;
    [SerializeField]
    GameObject PerkUI;
    [SerializeField]
    GameObject map;
    [SerializeField]
    Material ground;

    CharacterController Player1ch;
    CharacterController Player2ch;

    private void Start()
    {

        Player1ch = Player1.GetComponent<CharacterController>();
        Player2ch = Player2.GetComponent<CharacterController>();

    }
    private void Update()
    {
        if (!Game)
        {
            Player1.SetActive(false);
            Player2.SetActive(false);
            Player1HB.SetActive(false);
            Player2HB.SetActive(false);
            GameUI.SetActive(false);
            map.SetActive(false);
            ground.color = new Color(0,0,0, 255);

            PerkUI.SetActive(true);

        }
        else
        {
            
            
            Player1.SetActive(true);
            Player2.SetActive(true);
            Player1HB.SetActive(true);
            Player2HB.SetActive(true);
            GameUI.SetActive(true);
            map.SetActive(true);
            ground.color = new Color(0.31f, 0.31f, 0.31f, 255);
            PerkUI.SetActive(false);

            
            



        }
    }
    public void RoundEnd(string player)
    {

        if (player == "player1")
        {
            player2_SCORE ++;
        }
        if (player == "player2")
        {
            player1_SCORE++;
        }

        Game = false;




        
        
    }
    public void RoundStart()
    {
        Game = true;
        player1_perkSelected = false;
        player2_perkSelected = false;
        Player1ch.enabled = false;
        Player2ch.enabled = false;
        Player1.transform.position = new Vector3(7, 0.5f, 1);
        Player2.transform.position = new Vector3(-7, 0.5f, 1);
        Player1ch.enabled = true;
        Player2ch.enabled = true;

        if (player1_perk_HealthIncrise1)
        {
            player1_Maxhealth = 1250;
        }
        if (player1_perk_HealthIncrise2)
        {
            player1_Maxhealth = 1500;
        }
        if (!player1_perk_HealthIncrise1 && !player1_perk_HealthIncrise2)
        {
            player1_Maxhealth = 1000;
        }
        if (player1_health > player1_Maxhealth)
        {
            player1_health = player1_Maxhealth;
        }


        if (player2_perk_HealthIncrise1)
        {
            player2_Maxhealth = 1250;
        }
        if (player2_perk_HealthIncrise2)
        {
            player2_Maxhealth = 1500;
        }
        if (!player2_perk_HealthIncrise1 && !player2_perk_HealthIncrise2)
        {
            player2_Maxhealth = 1000;
        }
        if (player2_health > player2_Maxhealth)
        {
            player2_health = player2_Maxhealth;
        }


        player1_health = player1_Maxhealth;
        player2_health = player2_Maxhealth;
        player1_mana = player1_Maxhealth;
        player2_mana = player2_Maxhealth;

    }
}