using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul9 : MonoBehaviour
{
    public bool azu9;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blue Button"))
        {
            azu9 = true;
        }
    }
}
