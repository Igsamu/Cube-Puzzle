using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final6 : MonoBehaviour
{
    public Amarillo6 amarillo6;
    public Negro6 negro6;
    public Rojo6 rojo6;
    public Rigidbody rb;
    public Reinicio6 reinicio6;

    void Start()
    {
        amarillo6 = FindObjectOfType<Amarillo6>();
        rojo6 = FindObjectOfType<Rojo6>();
        negro6 = FindObjectOfType<Negro6>();
    }

    private void Update()
    {
        if (negro6.neg6 == true && amarillo6.ama6 == true && rojo6.roj6 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
            reinicio6.enabled = false;
        }
    }
}
