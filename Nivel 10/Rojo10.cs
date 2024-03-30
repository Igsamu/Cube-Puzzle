using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo10 : MonoBehaviour
{
    public bool roj10;
    public Amarillo10 amarillo10;
    public Verde10 verde10;
    public Azul10 azul10;

    private void Start()
    {
        amarillo10 = FindObjectOfType<Amarillo10>();
        verde10 = FindObjectOfType<Verde10>();
        azul10 = FindObjectOfType<Azul10>();
    }

    private void Update()
    {
        if (amarillo10.ama10 == false && azul10.azu10 == false && verde10.ver10 == false && roj10 == true)
        {
            amarillo10.ama10 = false;
            azul10.azu10 = false;
            verde10.ver10 = false;
            roj10 = false;
        }
        if (amarillo10.ama10 == true && azul10.azu10 == false && verde10.ver10 == false && roj10 == true)
        {
            amarillo10.ama10 = false;
            azul10.azu10 = false;
            verde10.ver10 = false;
            roj10 = false;
        }
        if (amarillo10.ama10 == true && azul10.azu10 == true && verde10.ver10 == false && roj10 == true)
        {
            amarillo10.ama10 = false;
            azul10.azu10 = false;
            verde10.ver10 = false;
            roj10 = false;
        }
        /*
        if (amarillo10.ama10 == true && azul10.azu10 == true && verde10.ver10 == true && roj10 == true)
        {
            amarillo10.ama10 = true;
            azul10.azu10 = true;
            verde10.ver10 = true;
            roj10 = true;
        }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red Button"))
        {
            roj10 = true;
        }
    }
}
