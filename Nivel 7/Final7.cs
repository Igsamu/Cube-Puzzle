using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final7 : MonoBehaviour
{
    public Verde7 verde7;
    public Rojo7 rojo7;
    public Amarillo7 amarillo7;
    public Azul7 azul7;
    public Negro7 negro7;
    public Rigidbody rb;
    public Reinicio7 reinicio7;

    private void Start()
    {
        verde7 = FindObjectOfType<Verde7>();
        rojo7 = FindObjectOfType<Rojo7>();
        amarillo7 = FindObjectOfType<Amarillo7>();
        azul7 = FindObjectOfType<Azul7>();
        negro7 = FindObjectOfType<Negro7>();
    }

    private void Update()
    {
        if(verde7.ver7 == true && rojo7.roj7 == true && amarillo7.ama7 == true && azul7.azu7 == true && negro7.neg7 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
            reinicio7.enabled = false;
        }
    }
}
