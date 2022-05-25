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
    List<GameObject> perks1 = new List<GameObject>();

    List<int> perks1_poradie = new List<int>();

    [SerializeField]
    List<Sprite> icons = new List<Sprite>();



    [SerializeField]
    List<GameObject> perks2 = new List<GameObject>();

    List<int> perks2_poradie = new List<int>();

 

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
            int pocet1 = 0;
            if (variables.player1_perk_lifesteal1)
                pocet1++;
            if (variables.player1_perk_lifesteal2)
                pocet1++;
            if (variables.player1_perk_critchance1)
                pocet1++;
            if (variables.player1_perk_critchance2)
                pocet1++;
            if (variables.player1_perk_critchance3)
                pocet1++;
            if (variables.player1_perk_bonusDMG1)
                pocet1++;
            if (variables.player1_perk_bonusDMG2)
                pocet1++;
            if (variables.player1_perk_speed)
                pocet1++;
            if (variables.player1_perk_HealthIncrise1)
                pocet1++;
            if (variables.player1_perk_HealthIncrise2)
                pocet1++;




            
            if (variables.player1_perk_lifesteal1)
            {
                if (!perks1_poradie.Contains(7))
                {
                        perks1_poradie.Add(7);
                }
            }
               
            if (variables.player1_perk_lifesteal2)
            {
                if (!perks1_poradie.Contains(8))
                {
                        perks1_poradie.Add(8);
                }
            }
                
            if (variables.player1_perk_critchance1)
            {
                if (!perks1_poradie.Contains(2))
                {
                        perks1_poradie.Add(2);
                }
            }
                
            if (variables.player1_perk_critchance2)
            {
                if (!perks1_poradie.Contains(3))
                {
                        perks1_poradie.Add(3);
                }
            }
                
            if (variables.player1_perk_critchance3)
            {
                if (!perks1_poradie.Contains(4))
                {
                        perks1_poradie.Add(4);
                }
            }
                
            if (variables.player1_perk_bonusDMG1)
            {
                if (!perks1_poradie.Contains(0))
                {
                        perks1_poradie.Add(0);
                }
            }
                
            if (variables.player1_perk_bonusDMG2)
            {
                if (!perks1_poradie.Contains(1))
                {
                        perks1_poradie.Add(1);
                }
            }
                
            if (variables.player1_perk_speed)
            {
                if (!perks1_poradie.Contains(9))
                {
                        perks1_poradie.Add(9);
                }
            }
                
            if (variables.player1_perk_HealthIncrise1)
            {
                if (!perks1_poradie.Contains(5))
                {
                        perks1_poradie.Add(5);
                }
            }
                
            if (variables.player1_perk_HealthIncrise2)
            {
                if (!perks1_poradie.Contains(6))
                {
                        perks1_poradie.Add(6);
                }
            }
                
            
            


      

            for (int i = 0; i < perks1.Count; i++)
            {
                perks1[i].SetActive(false);
                
            }
            for (int i = 0; i < pocet1; i++)
            {
                perks1[i].SetActive(true);
                perks1[i].GetComponent<Image>().sprite = icons[perks1_poradie[i]];
            }






            //-----player2-------
            int pocet2 = 0;
            if (variables.player2_perk_lifesteal1)
                pocet2++;
            if (variables.player2_perk_lifesteal2)
                pocet2++;
            if (variables.player2_perk_critchance1)
                pocet2++;
            if (variables.player2_perk_critchance2)
                pocet2++;
            if (variables.player2_perk_critchance3)
                pocet2++;
            if (variables.player2_perk_bonusDMG1)
                pocet2++;
            if (variables.player2_perk_bonusDMG2)
                pocet2++;
            if (variables.player2_perk_speed)
                pocet2++;
            if (variables.player2_perk_HealthIncrise1)
                pocet2++;
            if (variables.player2_perk_HealthIncrise2)
                pocet2++;




            if (variables.player2_perk_lifesteal1)
            {
                if (!perks2_poradie.Contains(7))
                {
                        perks2_poradie.Add(7);
                }
            }

            if (variables.player2_perk_lifesteal2)
            {
                if (!perks2_poradie.Contains(8))
                {
                        perks2_poradie.Add(8);
                }
            }

            if (variables.player2_perk_critchance1)
            {
                if (!perks2_poradie.Contains(2))
                {
                        perks2_poradie.Add(2);
                }
            }

            if (variables.player2_perk_critchance2)
            {
                if (!perks2_poradie.Contains(3))
                {
                        perks2_poradie.Add(3);
                }
            }

            if (variables.player2_perk_critchance3)
            {
                if (!perks2_poradie.Contains(4))
                {
                        perks2_poradie.Add(4);
                }
            }

            if (variables.player2_perk_bonusDMG1)
            {
                if (!perks2_poradie.Contains(0))
                {
                        perks2_poradie.Add(0);
                }
            }

            if (variables.player2_perk_bonusDMG2)
            {
                if (!perks2_poradie.Contains(1))
                {
                        perks2_poradie.Add(1);
                }
            }

            if (variables.player2_perk_speed)
            {
                if (!perks2_poradie.Contains(9))
                {
                        perks2_poradie.Add(9);
                }
            }

            if (variables.player2_perk_HealthIncrise1)
            {
                if (!perks2_poradie.Contains(5))
                {
                        perks2_poradie.Add(5);
                }
            }

            if (variables.player2_perk_HealthIncrise2)
            {
                if (!perks2_poradie.Contains(6))
                {
                        perks2_poradie.Add(6);
                }
            }





        


            for (int i = 0; i < perks2.Count; i++)
            {
                perks2[i].SetActive(false);

            }
            for (int i = 0; i < pocet2; i++)
            {
                perks2[i].SetActive(true);
                perks2[i].GetComponent<Image>().sprite = icons[perks2_poradie[i]];
            }







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

