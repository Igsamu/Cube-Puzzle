using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verde7 : MonoBehaviour
{
    public bool ver7;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Green Button"))
        {
            ver7 = true;
        }
    }
}
