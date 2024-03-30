using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amarillo9 : MonoBehaviour
{
    public bool ama9;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Yellow Button"))
        {
            ama9 = true;
        }
    }
}
