using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    List<GameObject> perks2 = new List<GameObject>();
    [SerializeField]
    GameObject selector2;
    void Start()
    {
        Player1 = player1.GetComponent<player>();
        Player2 = player2.GetComponent<player>();
        variables = manager.GetComponent<Manazer>();
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
            selector1.transform.position = new Vector2(perks1[player1Selected].transform.position.x, perks1[player1Selected].transform.position.y);
            selector2.transform.position = new Vector2(perks2[player2Selected].transform.position.x, perks2[player2Selected].transform.position.y);

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
