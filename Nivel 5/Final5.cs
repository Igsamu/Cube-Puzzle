using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final5 : MonoBehaviour
{
    public Amarillo5 amarillo5;
    public Azul5 azul5;
    public Negro5 negro5;
    public Rigidbody rb;
    public Reinicio5 reinicio5;

    void Start()
    {
        amarillo5 = FindObjectOfType<Amarillo5>();
        azul5 = FindObjectOfType<Azul5>();
        negro5 = FindObjectOfType<Negro5>();
    }

    private void Update()
    {
        if (negro5.neg5 == 1 && amarillo5.ama5 == 1 && azul5.azu5 == 1)
        {
            rb.constraints = RigidbodyConstraints.None;
            reinicio5.enabled = false;
        }
    }
}
