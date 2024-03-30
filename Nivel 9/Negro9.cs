using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negro9 : MonoBehaviour
{
    public bool neg9;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Black Button"))
        {
            neg9 = true;
        }
    }
}
