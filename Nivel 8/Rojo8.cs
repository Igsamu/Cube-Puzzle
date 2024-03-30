using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo8 : MonoBehaviour
{
    public bool roj8;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Red Button"))
        {
            roj8 = true;
        }
    }
}
