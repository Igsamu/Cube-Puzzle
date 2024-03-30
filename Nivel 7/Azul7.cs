using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul7 : MonoBehaviour
{
    public bool azu7;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Blue Button"))
        {
            azu7 = true;
        }
    }
}
