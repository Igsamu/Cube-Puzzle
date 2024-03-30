using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verde10 : MonoBehaviour
{
    public bool ver10;

    public Amarillo10 amarillo10;
    public Rojo10 rojo10;
    public Azul10 azul10;

    private void Start()
    {
        amarillo10 = FindObjectOfType<Amarillo10>();
        rojo10 = FindObjectOfType<Rojo10>();
        azul10 = FindObjectOfType<Azul10>();
    }
    private void Update()
    {
       if(amarillo10.ama10 == false && azul10.azu10 == false && ver10 == true)
        {
            amarillo10.ama10 = false;
            azul10.azu10 = false;
            ver10 = false;
            rojo10.roj10 = false;
        }
       if(amarillo10.ama10 == true && azul10.azu10 == false && ver10 == true)
        {
            amarillo10.ama10 = false;
            azul10.azu10 = false;
            ver10 = false;
            rojo10.roj10 = false;
        }
       /*
       if (amarillo10.ama10 == true && azul10.azu10 == true && ver10 == true)
        {
            amarillo10.ama10 = true;
            azul10.azu10 = true;
            ver10 = true;
            rojo10.roj10 = false;
        }
       */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Green Button"))
        {
            ver10 = true;
        }
    }
}
