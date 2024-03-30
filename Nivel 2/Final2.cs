using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final2 : MonoBehaviour
{
    public Negro2 negro2;
    public Rigidbody rb;
    public Reinicio2 reinicio2;

    void Start()
    {
        negro2 = FindObjectOfType<Negro2>();
    }

    private void Update()
    {
        if (negro2.neg2 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
            reinicio2.enabled = false;
        }
    }
}
