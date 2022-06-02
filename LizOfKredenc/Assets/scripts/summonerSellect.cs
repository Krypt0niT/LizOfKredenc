using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class summonerSellect : MonoBehaviour
{
    [SerializeField]
    GameObject manager;
    Manazer variables;

    GameObject audioManager;
    AudioManager sounds;
    AudioSource source;


    [SerializeField]
    List<GameObject> sums1 = new List<GameObject>();
    [SerializeField]
    GameObject selector1;
    [SerializeField]
    TMP_Text info1;
    int player1selected = 0;

    [SerializeField]
    List<GameObject> sums2 = new List<GameObject>();
    [SerializeField]
    GameObject selector2;
    [SerializeField]
    TMP_Text info2;
    int player2selected = 0;

    string flashInfo = "Instant teleport to close destance";
    string speedInfo = "Burst of speed over time";

    void Start()
    {
        variables = manager.GetComponent<Manazer>();

        audioManager = GameObject.Find("AudioManager");
        sounds = audioManager.GetComponent<AudioManager>();
        source = audioManager.GetComponent<AudioSource>();
        info1.text = flashInfo;
        info2.text = flashInfo;

    }

    void Update()
    {
        if (variables.player1_sumSelected && variables.player2_sumSelected)
        {
            variables.firstSelect = false;
            this.gameObject.SetActive(false);
            variables.Game = true;
        }
    }
    public void IndexCalculator(string direction, int index)
    {
        if (variables.firstSelect)
        {
            if (!variables.Game)
            {
                source.PlayOneShot(sounds.perkMove);
                if (index == 0)
                {
                    if (!variables.player1_sumSelected)
                    {
                        if (player1selected == 0)
                        {
                            player1selected = 1;
                            info1.text = speedInfo;

                        }
                        else
                        {
                            player1selected = 0;
                            info1.text = flashInfo;
                        }
                    }

                }
                selector1.transform.position = sums1[player1selected].transform.position;
                if (index == 1)
                {
                    if (player2selected == 0)
                    {
                        player2selected = 1;
                        info2.text = speedInfo;

                    }
                    else
                    {
                        player2selected = 0;
                        info2.text = flashInfo;
                    }
                }
                selector2.transform.position = sums2[player2selected].transform.position;
            }
        }
        

    }
    public void sumPick(int index)
    {
        source.PlayOneShot(sounds.perkSelect);
        if (index == 0)
        {
            if (player1selected == 0)
            {
                variables.player1_summonerSpell = "flash";
            }
            else
            {
                variables.player1_summonerSpell = "speed";

            }
            variables.player1_sumSelected = true;
        }

        if (index == 1)
        {
            if (player2selected == 0)
            {
                variables.player2_summonerSpell = "flash";
            }
            else
            {
                variables.player2_summonerSpell = "speed";

            }
            variables.player2_sumSelected = true;

        }
    }
}
