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
    float alfa = 0;
    void Start()
    {
        transform.position += transform.forward  *(this.transform.localScale.z / 2);
        material.color = new Color(material.color.r, material.color.g, material.color.b, alfa);
    }

    void Update()
    {
        start += Time.deltaTime;

        material.color = new Color(material.color.r, material.color.g, material.color.b, alfa);
        if (alfa <= 1)
            alfa += Time.deltaTime / time;
        if (start >= time)
        {
            print("damage");
            if (start >= time + 2)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
