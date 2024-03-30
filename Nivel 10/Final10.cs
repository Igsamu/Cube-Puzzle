using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final10 : MonoBehaviour
{
    public Amarillo10 amarillo10;
    public Rojo10 rojo10;
    public Verde10 verde10;
    public Azul10 azul10;
    public Rigidbody rb;
    public Reinicio10 reinicio10;

    void Start()
    {
        rojo10 = FindObjectOfType<Rojo10>();
        amarillo10 = FindObjectOfType<Amarillo10>();
        azul10 = FindObjectOfType<Azul10>();
        verde10 = FindObjectOfType<Verde10>();
    }
    void Update()
    {
        if (amarillo10.ama10 == true && rojo10.roj10 == true && azul10.azu10 == true && verde10.ver10 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
            reinicio10.enabled = false;
        }
    }
}
