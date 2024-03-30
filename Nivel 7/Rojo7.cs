using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo7 : MonoBehaviour
{
    public bool roj7;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Red Button"))
        {
            roj7 = true;
        }
    }
}
