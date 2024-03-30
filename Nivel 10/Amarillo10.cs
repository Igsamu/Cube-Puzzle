using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amarillo10 : MonoBehaviour
{
    public bool ama10;
    public Verde10 verde10;
    public Azul10 azul10;
    public Rojo10 rojo10;

    private void Start()
    {
        verde10 = FindObjectOfType<Verde10>();
        azul10 = FindObjectOfType<Azul10>();
        rojo10 = FindObjectOfType<Rojo10>();
    }
    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Yellow Button"))
        {
            ama10 = true;
        }
    }
}
