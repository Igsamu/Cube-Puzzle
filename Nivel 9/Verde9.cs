using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verde9 : MonoBehaviour
{
    public bool ver9;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Green Button"))
        {
            ver9 = true;
        }
    }
}
