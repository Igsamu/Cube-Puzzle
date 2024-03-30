using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaRojo9 : MonoBehaviour
{
    public Rojo9 rojo9;
    public Rigidbody rb;

    private void Start()
    {
        rojo9 = FindObjectOfType<Rojo9>();
    }

    private void Update()
    {
        if(rojo9.roj9 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
