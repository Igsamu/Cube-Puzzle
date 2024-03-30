using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul11 : MonoBehaviour
{
    public bool azu11;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Blue Button"))
        {
            azu11 = true;
        }
    }
}
