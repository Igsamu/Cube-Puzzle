using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negro7 : MonoBehaviour
{
    public bool neg7;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Black Button"))
        {
            neg7 = true;
        }
    }
}
