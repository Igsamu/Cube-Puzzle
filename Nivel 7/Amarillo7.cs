using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amarillo7 : MonoBehaviour
{
    public bool ama7;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Yellow Button"))
        {
            ama7 = true;
        }
    }
}
