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
    GameObject manager;
    //manager managerscript = manager.GetComponent<manager>();


    void Start()
    {
        t = GetComponent<Transform>();
        startRotation = t.rotation;
        playerTransform.GetComponent<Transform>();
        print(playerTransform);
    }

    void Update()
    {
        t.position = new Vector3(playerTransform.transform.position.x,transform.position.y,playerTransform.transform.position.z);
        if (transform.parent.name == "P1_healthBar")
        {
            if(this.name == "health")
            {
               // t.localScale = new Vector3();
            }
        }
    }
}
