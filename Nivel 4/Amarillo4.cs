using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amarillo4 : MonoBehaviour
{
    public bool ama4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Yellow Button"))
        {
            ama4 = true;
        }
    }
}
