using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul4 : MonoBehaviour
{
    public bool azu4;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Blue Button"))
        {
            azu4 = true;
        }
    }
}
