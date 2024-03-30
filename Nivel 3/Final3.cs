using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final3 : MonoBehaviour
{
    public Rojo3 rojo3;
    public Rigidbody rb;
    public Reinicio3 reinicio3;

    void Start()
    {
        rojo3 = FindObjectOfType<Rojo3>();
    }

    private void Update()
    {
        if (rojo3.roj3 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
            reinicio3.enabled = false;
        }
    }
}
