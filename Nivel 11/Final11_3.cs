using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final11_3 : MonoBehaviour
{
    public Rigidbody rb;
    public Reinicio11_3 reinicio11_3;
    public Negro11 negro11;

    private void Start()
    {
        negro11 = FindObjectOfType<Negro11>();
        reinicio11_3 = FindObjectOfType<Reinicio11_3>();
    }

    private void Update()
    {
        if(negro11.neg11 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
            reinicio11_3.enabled = false;
        }
    }
}
