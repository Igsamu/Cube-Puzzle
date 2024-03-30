using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Movement movement;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            movement.enabled = false;
        }
    }
}
