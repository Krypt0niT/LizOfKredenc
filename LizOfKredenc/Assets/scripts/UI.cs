using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField]
    GameObject manager;
    Manazer variables;

    [SerializeField]
    GameObject Player1;
    player Player1variables;
    [SerializeField]
    GameObject Player2;
    player Player2variables;


    [SerializeField]
    GameObject Summoner1_spell_BG;
    [SerializeField]
    GameObject Summoner1_spell_color;

    RectTransform summoner1_spell_Rect;

    [SerializeField]
    GameObject Summoner2_spell_BG;
    [SerializeField]
    GameObject Summoner2_spell_color;

    RectTransform summoner2_spell_Rect;



    void Start()
    {

        variables = manager.GetComponent<Manazer>();


        Player1variables = Player1.GetComponent<player>();
        Player2variables = Player2.GetComponent<player>();


        summoner1_spell_Rect = Summoner1_spell_color.GetComponent<RectTransform>();
        summoner2_spell_Rect = Summoner2_spell_color.GetComponent<RectTransform>();




    }

    void Update()
    {
        
        summoner1_spell_Rect.localScale = new Vector2(Player1variables.flash_time / variables.cooldown_flash * 0.5f ,summoner1_spell_Rect.localScale.y);
        summoner2_spell_Rect.localScale = new Vector2(Player2variables.flash_time / variables.cooldown_flash * 0.5f, summoner2_spell_Rect.localScale.y);

    }
}

