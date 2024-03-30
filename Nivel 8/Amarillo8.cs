using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amarillo8 : MonoBehaviour
{
    public bool ama8;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Yellow Button"))
        {
            ama8 = true;
        }
    }
}
