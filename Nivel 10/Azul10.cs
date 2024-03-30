using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul10 : MonoBehaviour
{
    public bool azu10;
    public Amarillo10 amarillo10;
    public Verde10 verde10;
    public Rojo10 rojo10;

    private void Start()
    {
        amarillo10 = FindObjectOfType<Amarillo10>();
        verde10 = FindObjectOfType<Verde10>();
        rojo10 = FindObjectOfType<Rojo10>();
    }

    private void Update()
    {
        if (azu10 == true && amarillo10.ama10 == false)
        {
            azu10 = false;
            amarillo10.ama10 = false;
            rojo10.roj10 = false;
            verde10.ver10 = false;
        }
        /*
        if (azu10 == true && amarillo10.ama10 == true)
        {
            azu10 = true;
            amarillo10.ama10 = true;
            rojo10.roj10 = false;
            verde10.ver10 = false;
        }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue Button"))
        {
            azu10 = true;
        }
    }
}
