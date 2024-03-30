using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaCubo11 : MonoBehaviour
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
            StartCoroutine(Reactiva());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Vacio"))
        {
            caida = true;
        }
    }
    IEnumerator Reactiva()
    {
        yield return new WaitForSeconds(1);
        boxCollider.enabled = true;
    }
}
