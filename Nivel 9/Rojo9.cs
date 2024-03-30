using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo9 : MonoBehaviour
{
    public bool roj9;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Red Button"))
        {
            roj9 = true;
        }
    }
}
