using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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




        info1.text = infotips[0];
        info2.text = infotips[0];

    }

    void Update()
    {
        if (variables.player1_perkSelected && variables.player2_perkSelected)
        {
            variables.RoundStart();
        }
    }
    public void IndexCalculator(string direction, int index)
    {
        if (index == 0)
        {
            if (direction == "DOWN")
            {
                player1Selected++;
                if (player1Selected == 5 )
                {
                    player1Selected = 0;
                }
                if (player1Selected == perks1.Count )
                {
                    player1Selected = perks1.Count/2;

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
                if (player1Selected > perks1.Count-1)
                {
                    player1Selected -= 10;
                }
            }
            if (direction == "LEFT")
            {
                player1Selected -= 5;
                if (player1Selected  < 0)
                {
                    player1Selected += 10;
                }
            }
            selector1.transform.position = new Vector2(perks1[player1Selected].transform.position.x, perks1[player1Selected].transform.position.y);
            info1.text = infotips[player1Selected];
        }
        if (index == 1)
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
            info2.text = infotips[player2Selected];
        }

    }
    public void perkPick(int index)
    {
        if (index == 0)
        {
            if (!variables.player1_perkSelected)
            {

            
                switch (player1Selected)
                {
                    case 0:
                        variables.player1_perk_bonusDMG1 = true;
                        break;
                    case 1:
                        variables.player1_perk_bonusDMG2 = true;
                        break;
                    case 2:
                        variables.player1_perk_critchance1 = true;
                        break;
                    case 3:
                        variables.player1_perk_critchance2 = true;
                        break;
                    case 4:
                        variables.player1_perk_critchance3 = true;
                        break;
                    case 5:
                        variables.player1_perk_HealthIncrise1 = true;
                        break;
                    case 6:
                        variables.player1_perk_HealthIncrise2 = true;
                        break;
                    case 7:
                        variables.player1_perk_lifesteal1 = true;
                        break;
                    case 8:
                        variables.player1_perk_lifesteal2 = true;
                        break;
                    case 9:
                        variables.player1_perk_speed = true;
                        break;


                }
            }
            variables.player1_perkSelected = true;
        }
        if (index == 1)
        {
            if (!variables.player2_perkSelected)
            {


                switch (player2Selected)
                {
                    case 0:
                        variables.player2_perk_bonusDMG1 = true;
                        break;
                    case 1:
                        variables.player2_perk_bonusDMG2 = true;
                        break;
                    case 2:
                        variables.player2_perk_critchance1 = true;
                        break;
                    case 3:
                        variables.player2_perk_critchance2 = true;
                        break;
                    case 4:
                        variables.player2_perk_critchance3 = true;
                        break;
                    case 5:
                        variables.player2_perk_HealthIncrise1 = true;
                        break;
                    case 6:
                        variables.player2_perk_HealthIncrise2 = true;
                        break;
                    case 7:
                        variables.player2_perk_lifesteal1 = true;
                        break;
                    case 8:
                        variables.player2_perk_lifesteal2 = true;
                        break;
                    case 9:
                        variables.player2_perk_speed = true;
                        break;


                }
            }
            variables.player2_perkSelected = true;
        }

    }

}
