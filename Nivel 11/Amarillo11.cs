using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amarillo11 : MonoBehaviour
{
    public bool ama11;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Yellow Button"))
        {
            ama11 = true;
        }
    }
}
