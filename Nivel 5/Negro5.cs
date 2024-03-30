using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negro5 : MonoBehaviour
{
    public int neg5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Black Button"))
        {
            neg5 = 1;
        }
    }
}
