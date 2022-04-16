using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    Transform t;
    [SerializeField]
    GameObject playerTransform;
    [SerializeField]
    GameObject manager;
    Manazer variables;
    [SerializeField]
    Material healthMaterial;
    float red;
    float green;
    
    

    void Start()
    {
        t = GetComponent<Transform>();
        playerTransform.GetComponent<Transform>();
        variables = manager.GetComponent<Manazer>();
    }

    void Update()
    {
        
        
        
        t.position = new Vector3(playerTransform.transform.position.x,transform.position.y,playerTransform.transform.position.z);
        if(name == "mana")
        {
            t.position = new Vector3(playerTransform.transform.position.x, transform.position.y, playerTransform.transform.position.z + 0.14063f);
        }
        if (name == "healthBarFrame")
        {
            t.position = new Vector3(playerTransform.transform.position.x, transform.position.y, playerTransform.transform.position.z + 0.03463f);
        }
        if (transform.parent.name == "P1_healthBar")
        {
            if(this.name == "health")
            {
                t.localScale = new Vector3(variables.player1_health/(variables.player1_Maxhealth / 0.2f), t.localScale.y,t.localScale.z);
                float Hpocet_dielikov = variables.player1_Maxhealth / variables.player1_health;
                float Hpercenta = 100 / Hpocet_dielikov;
               
                t.position = new Vector3(t.position.x + ((100f-Hpercenta)/100), t.position.y, t.position.z);
                green =  Hpercenta/100;
                red = 1-(Hpercenta/100);
    
                healthMaterial.color = new Color(red,green, 0f, 255);
                
       
            }
            if(this.name == "mana")
            {
                t.localScale = new Vector3(variables.player1_mana / (variables.player1_Maxmana / 0.2f), t.localScale.y, t.localScale.z);
                float Mpocet_dielikov = variables.player1_Maxmana / variables.player1_mana;
                float Mpercenta = 100 / Mpocet_dielikov;

                t.position = new Vector3(t.position.x + ((100f - Mpercenta) / 100), t.position.y, t.position.z);
                
                //healthMaterial.color = new Color(red, green, 0, 255);
            }
        }
    }
}
