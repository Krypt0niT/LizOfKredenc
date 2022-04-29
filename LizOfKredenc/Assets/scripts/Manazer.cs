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

    public string player1_summonerSpell = "speed";
    public bool player1_speedActive = false;





    public float player2_Maxhealth = 1000;
    public float player2_health = 1000;
    public float player2_healthRegen = 100;

    
    public float player2_Maxmana = 250;
    public float player2_mana = 250;
    public float player2_manaRegen = 50;

    public float player2_speed = 5;
    public float player2_projectileDMG = 200;

    public string player2_summonerSpell = "flash";
    public bool player2_speedActive = false;




    //vseobecne pravidla hry
    public float manaCost_flash = 100;
    public float manaCost_projectile = 20;
    public float cooldown_projectile = 3;
    public float cooldown_flash = 0.5f;
    public float manaCost_speed = 100;
    public float cooldown_speed = 10;
    public float lengh_speed = 5;
}