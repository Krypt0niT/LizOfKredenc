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
    
    

    void Start()
    {
        t = GetComponent<Transform>();
        playerTransform.GetComponent<Transform>();
        variables = manager.GetComponent<Manazer>();
    }

    void Update()
    {
        
        print(variables.player1_health);
        
        t.position = new Vector3(playerTransform.transform.position.x,transform.position.y,playerTransform.transform.position.z);
        if (transform.parent.name == "P1_healthBar")
        {
            if(this.name == "health")
            {
                //t.localScale = new Vector3();
            }
        }
    }
}
