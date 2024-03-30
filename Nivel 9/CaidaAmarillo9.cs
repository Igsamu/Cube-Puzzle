using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaAmarillo9 : MonoBehaviour
{
    public Amarillo9 amarillo9;
    public Rigidbody rb;

    private void Start()
    {
        amarillo9 = FindObjectOfType<Amarillo9>();
    }
    private void Update()
    {
        if (amarillo9.ama9 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
