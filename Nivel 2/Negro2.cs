using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negro2 : MonoBehaviour
{
    public bool neg2;

    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Black Button"))
        {
            neg2 = true;
        }
    }
}
