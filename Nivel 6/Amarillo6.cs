using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amarillo6 : MonoBehaviour
{
    public bool ama6;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Yellow Button"))
        {
            ama6 = true;
        }
    }
}
