using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo: MonoBehaviour
{
    public int roj;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red Button"))
        {
            roj = 1;
        }
    }
}
