using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaCubo3 : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider boxCollider;
    public bool caida;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(caida == true)
        {
            rb.constraints = RigidbodyConstraints.None;
            boxCollider.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Vacio"))
        {
            caida = true;
        }
    }
}
