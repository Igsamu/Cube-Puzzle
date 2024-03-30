using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo6 : MonoBehaviour
{
    public bool roj6;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Red Button"))
        {
            roj6 = true;
        }
    }
}
