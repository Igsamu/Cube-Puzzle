using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negro6 : MonoBehaviour
{
    public bool neg6;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Black Button"))
        {
            neg6 = true;
        }
    }
}
