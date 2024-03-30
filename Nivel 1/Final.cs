using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public Rojo rojo;
    public Rigidbody rb;
    public Reinicio reinicio;
    void Start()
    {
        rojo = FindObjectOfType<Rojo>();
    }

    void Update()
    {
        if (rojo.roj == 1)
        {
            rb.constraints = RigidbodyConstraints.None;
            reinicio.enabled = false;
        }
    }
}
