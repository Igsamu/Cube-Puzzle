using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negro8 : MonoBehaviour
{
    public bool neg8;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Black Button"))
        {
            neg8 = true;
        }
    }
}
