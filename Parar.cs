using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parar : MonoBehaviour
{
    public Movement movement;


    private void OnTriggerExit (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            movement.enabled = false;
        }
    }

}
