using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blast : MonoBehaviour
{



    float timeAlive = 0;
    [SerializeField]
    float DlzkaZivota = 5;
    [SerializeField]
    float projectileSpeed = 15;

    GameObject manazer;
    Manazer variables;


    void Update()
    {


        transform.position += transform.forward * Time.deltaTime * projectileSpeed;
  


        timeAlive += Time.deltaTime;
        if (timeAlive >= DlzkaZivota)
        {

            Destroy(gameObject);
        }
    }
}
