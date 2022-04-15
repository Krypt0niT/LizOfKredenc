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
    float red = 0;
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
        if (transform.parent.name == "P1_healthBar")
        {
            if(this.name == "health")
            {
                t.localScale = new Vector3(variables.player1_health/5000, t.localScale.y,t.localScale.z);
                float pocet_dielikov = variables.player1_Maxhealth / variables.player1_health;
                float percenta = 100 / pocet_dielikov;
               
                t.position = new Vector3(t.position.x + ((100f-percenta)/100), t.position.y, t.position.z);
                green =  percenta/100;
                red = 1-(percenta/100);
                print(green);
                healthMaterial.color = new Color(red,green, 0, 255);
                
       
            }
        }
    }
}
