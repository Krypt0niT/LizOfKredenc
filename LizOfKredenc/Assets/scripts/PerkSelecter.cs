using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PerkSelecter : MonoBehaviour
{
    [SerializeField]
    GameObject player1;
    player Player1;
    [SerializeField]
    GameObject player2;
    player Player2;
    [SerializeField]
    GameObject manager;
    Manazer variables;

    GameObject audioManager;
    AudioManager sounds;
    AudioSource source;
    int player1Selected = 0;
    int player2Selected = 0;
    [SerializeField]
    List<GameObject> perks1 = new List<GameObject>();
    [SerializeField]
    GameObject selector1;
    [SerializeField]
    TMP_Text info1;

    [SerializeField]
    List<GameObject> perks2 = new List<GameObject>();
    [SerializeField]
    GameObject selector2;
    [SerializeField]
    TMP_Text info2;
    [SerializeField]
    TMP_Text score;





    List<string> infotips = new List<string>
    {
        "Base damage will be increased \n(0% -> 10%)",
        "Base damage will be increased \n(10% -> 20%)",
        "Chance of critical strike will be increased \n(10% -> 20%)",
        "Chance of critical strike will be increased \n(20% -> 30%)",
        "Chance of critical strike will be increased \n(30% -> 45%)",
        "Your health will be increased \n(1000 -> 1250)",
        "Your health will be increased \n(1250 -> 1500)",
        "Healing from total damage \n(0% -> 33%)",
        "Healing from total damage \n(33% -> 50%)",
        "Base speed will be increased"
    };
    void Start()
    {
        Player1 = player1.GetComponent<player>();
        Player2 = player2.GetComponent<player>();
        variables = manager.GetComponent<Manazer>();

        audioManager = GameObject.Find("AudioManager");
        sounds = audioManager.GetComponent<AudioManager>();
        source = audioManager.GetComponent<AudioSource>();




        info1.text = infotips[0];
        info2.text = infotips[0];


    }

    void Update()
    {
        if (variables.player1_perkSelected && variables.player2_perkSelected)
        {
            variables.RoundStart();
        }

        // score

        score.text = variables.player1_SCORE + " : " + variables.player2_SCORE;



        //blokovanie operkov

        if (!variables.player1_perk_bonusDMG1)
        {
            perks1[1].GetComponent<Image>().color = new Color(0.2f,0.2f, 0.2f, 255);
        }
        else
        {
            variables.player1_perk_bonusDMG2_avaiable = true;
            perks1[1].GetComponent<Image>().color = new Color(0.5f, 0.75f, 0.9f, 255);

        }
        
        if (!variables.player1_perk_critchance1)
        {
            perks1[3].GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 255);

        }
        else
        {
            variables.player1_perk_critchance2_avaiable = true;
            perks1[3].GetComponent<Image>().color = new Color(0.5f, 0.75f, 0.9f, 255);

        }
        if (!variables.player1_perk_critchance2)
        {
            perks1[4].GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 255);

        }
        else
        {
            variables.player1_perk_critchance3_avaiable = true;
            perks1[4].GetComponent<Image>().color = new Color(0.7f, 0.95f, 1f, 255);

        }
        if (!variables.player1_perk_HealthIncrise1)
        {
            perks1[6].GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 255);

        }
        else
        {
            variables.player1_perk_HealthIncrise2_avaiable = true;
            perks1[6].GetComponent<Image>().color = new Color(0.5f, 0.75f, 0.9f, 255);

        }
        if (!variables.player1_perk_lifesteal1)
        {
            perks1[8].GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 255);

        }
        else
        {
            variables.player1_perk_lifesteal2_avaiable = true;
            perks1[8].GetComponent<Image>().color = new Color(0.5f, 0.75f, 0.9f, 255);

        }



        //player 2
        if (!variables.player2_perk_bonusDMG1)
        {
            perks2[1].GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 255);
        }
        else
        {
            variables.player2_perk_bonusDMG2_avaiable = true;
            perks2[1].GetComponent<Image>().color = new Color(0.87f, 0.4f, 0.45f, 255);

        }

        if (!variables.player2_perk_critchance1)
        {
            perks2[3].GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 255);

        }
        else
        {
            variables.player2_perk_critchance2_avaiable = true;
            perks2[3].GetComponent<Image>().color = new Color(0.87f, 0.4f, 0.45f, 255);

        }
        if (!variables.player2_perk_critchance2)
        {
            perks2[4].GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 255);

        }
        else
        {
            variables.player2_perk_critchance3_avaiable = true;
            perks2[4].GetComponent<Image>().color = new Color(1f, 0.6f, 0.65f, 255);

        }
        if (!variables.player2_perk_HealthIncrise1)
        {
            perks2[6].GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 255);

        }
        else
        {
            variables.player2_perk_HealthIncrise2_avaiable = true;
            perks2[6].GetComponent<Image>().color = new Color(0.87f, 0.4f, 0.45f, 255);

        }
        if (!variables.player2_perk_lifesteal1)
        {
            perks2[8].GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 255);

        }
        else
        {
            variables.player2_perk_lifesteal2_avaiable = true;
            perks2[8].GetComponent<Image>().color = new Color(0.87f, 0.4f, 0.45f, 255);

        }





    }
    public void IndexCalculator(string direction, int index)
    {
        if (!variables.Game)
        {
            if (index == 0)
            {
                if (!variables.player1_perkSelected)
                {
                    if (direction == "DOWN")
                    {
                        player1Selected++;
                        if (player1Selected == 5)
                        {
                            player1Selected = 0;
                        }
                        if (player1Selected == perks1.Count)
                        {
                            player1Selected = perks1.Count / 2;

                        }
                    }
                    if (direction == "UP")
                    {
                        player1Selected--;
                        if (player1Selected < 0)
                        {
                            player1Selected = 4;
                        }
                        else if (player1Selected == 4)
                        {
                            player1Selected = perks1.Count - 1;
                        }
                    }
                    if (direction == "RIGHT")
                    {
                        player1Selected += 5;
                        if (player1Selected > perks1.Count - 1)
                        {
                            player1Selected -= 10;
                        }
                    }
                    if (direction == "LEFT")
                    {
                        player1Selected -= 5;
                        if (player1Selected < 0)
                        {
                            player1Selected += 10;
                        }
                    }
                    selector1.transform.position = new Vector2(perks1[player1Selected].transform.position.x, perks1[player1Selected].transform.position.y);
                    info1.color = new Color(1, 1, 1, 255);
                    info1.text = infotips[player1Selected];

                    source.PlayOneShot(sounds.perkMove);


                    if (perks1[player1Selected].GetComponent<Image>().color == new Color(0.2f, 0.2f, 0.2f, 255))
                    {
                        info1.text = "You have to unlock previous to get this one";
                        info1.color = new Color(1, 0, 0, 255);
                    }
                }

            }
            if (index == 1)
            {
                if (!variables.player2_perkSelected)
                {
                    if (direction == "DOWN")
                    {
                        player2Selected++;
                        if (player2Selected == 5)
                        {
                            player2Selected = 0;
                        }
                        if (player2Selected == perks2.Count)
                        {
                            player2Selected = perks2.Count / 2;

                        }
                    }
                    if (direction == "UP")
                    {
                        player2Selected--;
                        if (player2Selected < 0)
                        {
                            player2Selected = 4;
                        }
                        else if (player2Selected == 4)
                        {
                            player2Selected = perks2.Count - 1;
                        }
                    }
                    if (direction == "RIGHT")
                    {
                        player2Selected += 5;
                        if (player2Selected > perks2.Count - 1)
                        {
                            player2Selected -= 10;
                        }
                    }
                    if (direction == "LEFT")
                    {
                        player2Selected -= 5;
                        if (player2Selected < 0)
                        {
                            player2Selected += 10;
                        }
                    }
                    selector2.transform.position = new Vector2(perks2[player2Selected].transform.position.x, perks2[player2Selected].transform.position.y);
                    info2.color = new Color(1, 1, 1, 255);
                    info2.text = infotips[player2Selected];
                    source.PlayOneShot(sounds.perkMove);



                    if (perks2[player2Selected].GetComponent<Image>().color == new Color(0.2f, 0.2f, 0.2f, 255))
                    {
                        info2.text = "You have to unlock previous to get this one";
                        info2.color = new Color(0, 0, 1, 255);
                    }

                }
            }
        }
        
                

    }
    public void perkPick(int index)
    {
        if (!variables.Game)
        {
            if (index == 0)
            {
                if (!variables.player1_perkSelected)
                {


                    switch (player1Selected)
                    {
                        case 0:
                            if (!variables.player1_perk_bonusDMG1)
                            {
                                variables.player1_perk_bonusDMG1 = true;
                                variables.player1_perkSelected = true;
                                source.PlayOneShot(sounds.perkSelect);

                            }

                            break;
                        case 1:
                            if (!variables.player1_perk_bonusDMG2)
                            {
                                if (variables.player1_perk_bonusDMG2_avaiable)
                                {
                                    variables.player1_perk_bonusDMG2 = true;
                                    variables.player1_perkSelected = true;
                                    source.PlayOneShot(sounds.perkSelect);

                                }
                            }
                            
                            break;
                        case 2:
                            if (!variables.player1_perk_critchance1)
                            {
                                variables.player1_perk_critchance1 = true;
                                variables.player1_perkSelected = true;
                                source.PlayOneShot(sounds.perkSelect);

                            }

                            break;
                        case 3:
                            if (!variables.player1_perk_critchance2)
                            {
                                if (variables.player1_perk_critchance2_avaiable)
                                {
                                    variables.player1_perk_critchance2 = true;
                                    variables.player1_perkSelected = true;
                                    source.PlayOneShot(sounds.perkSelect);

                                }
                            }
                            
                            
                            break;
                        case 4:
                            if (!variables.player1_perk_critchance3)
                            {
                                if (variables.player1_perk_critchance3_avaiable)
                                {
                                    variables.player1_perk_critchance3 = true;
                                    variables.player1_perkSelected = true;
                                    source.PlayOneShot(sounds.perkSelect);

                                }
                            }
                            
                            break;
                        case 5:
                            if (!variables.player1_perk_HealthIncrise1)
                            {
                                variables.player1_perk_HealthIncrise1 = true;
                                variables.player1_perkSelected = true;
                                source.PlayOneShot(sounds.perkSelect);

                            }

                            break;
                        case 6:
                            if (!variables.player1_perk_HealthIncrise2)
                            {
                                if (variables.player1_perk_HealthIncrise2_avaiable)
                                {
                                    variables.player1_perk_HealthIncrise2 = true;
                                    variables.player1_perkSelected = true;
                                    source.PlayOneShot(sounds.perkSelect);

                                }
                            }
                            
                            
                            break;
                        case 7:
                            if (!variables.player1_perk_lifesteal1)
                            {
                                variables.player1_perk_lifesteal1 = true;
                                variables.player1_perkSelected = true;
                                source.PlayOneShot(sounds.perkSelect);

                            }

                            break;
                        case 8:
                            if (!variables.player1_perk_lifesteal2)
                            {
                                if (variables.player1_perk_lifesteal2_avaiable)
                                {
                                    variables.player1_perk_lifesteal2 = true;
                                    variables.player1_perkSelected = true;
                                    source.PlayOneShot(sounds.perkSelect);

                                }
                            }
                            
                            
                            break;
                        case 9:
                            if (!variables.player1_perk_speed)
                            {
                                variables.player1_perk_speed = true;
                                variables.player1_perkSelected = true;
                                source.PlayOneShot(sounds.perkSelect);

                            }

                            break;


                    }
                }
                
            }
            if (index == 1)
            {
                if (!variables.player2_perkSelected)
                {


                    switch (player2Selected)
                    {
                        case 0:
                            if (!variables.player2_perk_bonusDMG1)
                            {
                                variables.player2_perk_bonusDMG1 = true;
                                variables.player2_perkSelected = true;
                                source.PlayOneShot(sounds.perkSelect);

                            }

                            break;
                        case 1:
                            if (!variables.player2_perk_bonusDMG2)
                            {
                                if (variables.player2_perk_bonusDMG2_avaiable)
                                {
                                    variables.player2_perk_bonusDMG2 = true;
                                    variables.player2_perkSelected = true;
                                    source.PlayOneShot(sounds.perkSelect);

                                }
                            }

                            break;
                        case 2:
                            if (!variables.player2_perk_critchance1)
                            {
                                variables.player2_perk_critchance1 = true;
                                variables.player2_perkSelected = true;
                                source.PlayOneShot(sounds.perkSelect);

                            }

                            break;
                        case 3:
                            if (!variables.player2_perk_critchance2)
                            {
                                if (variables.player2_perk_critchance2_avaiable)
                                {
                                    variables.player2_perk_critchance2 = true;
                                    variables.player2_perkSelected = true;
                                    source.PlayOneShot(sounds.perkSelect);

                                }
                            }


                            break;
                        case 4:
                            if (!variables.player2_perk_critchance3)
                            {
                                if (variables.player2_perk_critchance3_avaiable)
                                {
                                    variables.player2_perk_critchance3 = true;
                                    variables.player2_perkSelected = true;
                                    source.PlayOneShot(sounds.perkSelect);

                                }
                            }

                            break;
                        case 5:
                            if (!variables.player2_perk_HealthIncrise1)
                            {
                                variables.player2_perk_HealthIncrise1 = true;
                                variables.player2_perkSelected = true;
                                source.PlayOneShot(sounds.perkSelect);

                            }

                            break;
                        case 6:
                            if (!variables.player2_perk_HealthIncrise2)
                            {
                                if (variables.player2_perk_HealthIncrise2_avaiable)
                                {
                                    variables.player2_perk_HealthIncrise2 = true;
                                    variables.player2_perkSelected = true;
                                    source.PlayOneShot(sounds.perkSelect);

                                }
                            }


                            break;
                        case 7:
                            if (!variables.player2_perk_lifesteal1)
                            {
                                variables.player2_perk_lifesteal1 = true;
                                variables.player2_perkSelected = true;
                                source.PlayOneShot(sounds.perkSelect);

                            }

                            break;
                        case 8:
                            if (!variables.player2_perk_lifesteal2)
                            {
                                if (variables.player2_perk_lifesteal2_avaiable)
                                {
                                    variables.player2_perk_lifesteal2 = true;
                                    variables.player2_perkSelected = true;
                                    source.PlayOneShot(sounds.perkSelect);

                                }
                            }


                            break;
                        case 9:
                            if (!variables.player2_perk_speed)
                            {
                                variables.player2_perk_speed = true;
                                variables.player2_perkSelected = true;
                                source.PlayOneShot(sounds.perkSelect);

                            }

                            break;


                    }
                }

            }
        }
        

    }

}
