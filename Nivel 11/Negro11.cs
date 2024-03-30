using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negro11 : MonoBehaviour
{
    public bool neg11;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Black Button"))
        {
            neg11 = true;
        }
    }
}
