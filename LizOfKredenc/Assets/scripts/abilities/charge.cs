using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charge : MonoBehaviour
{
    [SerializeField]
    Material material;
    [SerializeField]
    float time = 3 ;

    float start = 0;
    float charger = 0;

    public bool damage = false;

    void Start()
    {
        transform.position += transform.forward  *(this.transform.localScale.z / 2);
        if (this.name == "ChargeP1(Clone)")
        {
            material.SetColor("_EmissionColor", new Color(0f, 0f, charger, 255));
        }
        if (this.name == "ChargeP2(Clone)")
        {
            material.SetColor("_EmissionColor", new Color(charger, 0f, 0f, 255));
        }

    }

    void Update()
    {
        start += Time.deltaTime;


        charger += Time.deltaTime / time;
        if (this.name == "ChargeP1(Clone)")
        {
            material.SetColor("_EmissionColor", new Color(0f, 0f, charger, 255));
        }
        if (this.name == "ChargeP2(Clone)")
        {
            material.SetColor("_EmissionColor", new Color(charger, 0f, 0f, 255));
        }


        if (start >= time)
        {
            if (this.name == "ChargeP1(Clone)")
            {
                material.SetColor("_EmissionColor", new Color(0.5f, 0.5f, charger, 255));
            }
            if (this.name == "ChargeP2(Clone)")
            {
                material.SetColor("_EmissionColor", new Color(charger, 0.5f, 0.5f, 255));
            }

            damage = true;
            if (start >= time + 2)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
