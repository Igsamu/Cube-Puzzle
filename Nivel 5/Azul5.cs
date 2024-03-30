using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul5 : MonoBehaviour
{
    public int azu5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue Button"))
        {
            azu5 = 1;
        }
    }
}
