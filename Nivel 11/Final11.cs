using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final11 : MonoBehaviour
{
    public Rigidbody rb;
    public Reinicio11 reinicio11;
    public Negro11 negro11;

    private void Start()
    {
        negro11 = FindObjectOfType<Negro11>();
        reinicio11 = FindObjectOfType<Reinicio11>();
    }

    private void Update()
    {
        if(negro11.neg11 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
            reinicio11.enabled = false;
        }
    }
}
