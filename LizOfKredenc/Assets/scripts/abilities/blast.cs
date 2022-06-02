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

    private void Start()
    {
        manazer = GameObject.Find("Manager");
        variables = manazer.GetComponent<Manazer>();
    }
    void Update()
    {


        transform.position += transform.forward * Time.deltaTime * projectileSpeed;
        if (!variables.Game)
        {
            Destroy(gameObject);

        }


        timeAlive += Time.deltaTime;
        if (timeAlive >= DlzkaZivota)
        {

            Destroy(gameObject);
        }
    }
}
