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
    public float player1_manaRegen = 20;

    public float player1_speed = 5;






    public float player2_Maxhealth = 1000;
    public float player2_health = 1000;
    public float player2_healthRegen = 100;

    
    public float player2_Maxmana = 250;
    public float player2_mana = 250;
    public float player2_manaRegen = 20;

    public float player2_speed = 5;



    //vseobecne pravidla hry
    public float manaCost_flash = 100;
    public float manaCost_projectile = 20;
    public float cooldown_projectile = 3    ;
}