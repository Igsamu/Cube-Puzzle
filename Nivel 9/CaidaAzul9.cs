using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaAzul9 : MonoBehaviour
{
    public Azul9 azul9;
    public Rigidbody rb;

    private void Start()
    {
        azul9 = FindObjectOfType<Azul9>();
    }

    private void Update()
    {
        if(azul9.azu9 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
