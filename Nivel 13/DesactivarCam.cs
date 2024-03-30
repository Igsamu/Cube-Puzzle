using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarCam : MonoBehaviour
{
    public bool DesCam;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DesCam = true;
        }
    }
}
