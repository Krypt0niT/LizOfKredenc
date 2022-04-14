using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    Transform t;
    Quaternion startRotation;
    [SerializeField]
    GameObject playerTransform;
    [SerializeField]
    GameObject Manager;

    manager ManagerVariables;
    int player1_health;
    

    void Start()
    {
        t = GetComponent<Transform>();
        startRotation = t.rotation;
        playerTransform.GetComponent<Transform>();
        ManagerVariables = GetComponent<manager>();
        player1_health = ManagerVariables.player1_health;   
        print(player1_health);
    }

    void Update()
    {
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
