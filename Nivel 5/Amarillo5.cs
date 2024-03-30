using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amarillo5 : MonoBehaviour
{
    public int ama5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Yellow Button"))
        {
            ama5 = 1;
        }
    }
}
