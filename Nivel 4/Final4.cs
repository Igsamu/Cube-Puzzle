using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final4 : MonoBehaviour
{
    public Amarillo4 amarillo4;
    public Azul4 azul4;
    public Rigidbody rb;
    public Reinicio4 reinicio4;

    void Start()
    {
        amarillo4 = FindObjectOfType<Amarillo4>();
        azul4 = FindObjectOfType<Azul4>();
    }

    private void Update()
    {
        if (amarillo4.ama4 == true && azul4.azu4 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
            reinicio4.enabled = false;
        }
    }
}
