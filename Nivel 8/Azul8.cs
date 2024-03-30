using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul8 : MonoBehaviour
{
    public bool azu8;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Blue Button"))
        {
            azu8 = true;
        }
    }
}
