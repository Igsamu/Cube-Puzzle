using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaVerde9 : MonoBehaviour
{
    public Verde9 verde9;
    public Rigidbody rb;

    private void Start()
    {
        verde9 = FindObjectOfType<Verde9>();
    }

    private void Update()
    {
        if(verde9.ver9 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
