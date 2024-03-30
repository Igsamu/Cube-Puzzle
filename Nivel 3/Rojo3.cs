using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo3 : MonoBehaviour
{
    public bool roj3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red Button"))
        {
            roj3 = true;
        }
    }
}
