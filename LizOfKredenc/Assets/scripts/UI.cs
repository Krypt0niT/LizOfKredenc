using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


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

    [SerializeField]
    TMP_Text Player1_Score;

    [SerializeField]
    TMP_Text Player2_Score;

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
        if (variables.Game)
        {



            //score docastne

            Player1_Score.text = variables.player1_SCORE.ToString();
            Player2_Score.text = variables.player2_SCORE.ToString();

            //------------

            if (variables.player1_summonerSpell == "flash")
            {
                summoner1_spell_Rect.localScale = new Vector2(Player1variables.flash_time / variables.cooldown_flash * 0.5f, summoner1_spell_Rect.localScale.y);


                if (Player1variables.flash_time >= variables.cooldown_flash)
                {
                    Summoner1_spell_color.GetComponent<Image>().color = new Color32(255, 255, 0, 225);
                }
                else
                {
                    Summoner1_spell_color.GetComponent<Image>().color = new Color32(183, 174, 0, 225);
                }
            }
            else if (variables.player1_summonerSpell == "speed")
            {
                summoner1_spell_Rect.localScale = new Vector2(Player1variables.speed_time / variables.cooldown_speed * 0.5f, summoner1_spell_Rect.localScale.y);


                if (Player1variables.speed_time >= variables.cooldown_speed)
                {
                    Summoner1_spell_color.GetComponent<Image>().color = new Color32(0, 191, 255, 225);
                }
                else
                {
                    Summoner1_spell_color.GetComponent<Image>().color = new Color32(0, 162, 211, 225);
                }

            }

            if (variables.player2_summonerSpell == "flash")
            {
                summoner2_spell_Rect.localScale = new Vector2(Player2variables.flash_time / variables.cooldown_flash * 0.5f, summoner2_spell_Rect.localScale.y);


                if (Player2variables.flash_time >= variables.cooldown_flash)
                {
                    Summoner2_spell_color.GetComponent<Image>().color = new Color32(255, 255, 0, 225);
                }
                else
                {
                    Summoner2_spell_color.GetComponent<Image>().color = new Color32(183, 174, 0, 225);
                }
            }
            else if (variables.player2_summonerSpell == "speed")
            {
                summoner2_spell_Rect.localScale = new Vector2(Player2variables.speed_time / variables.cooldown_speed * 0.5f, summoner2_spell_Rect.localScale.y);


                if (Player2variables.speed_time >= variables.cooldown_speed)
                {
                    Summoner2_spell_color.GetComponent<Image>().color = new Color32(0, 191, 255, 225);
                }
                else
                {
                    Summoner2_spell_color.GetComponent<Image>().color = new Color32(0, 162, 211, 225);
                }
            }
        }
    }
}

