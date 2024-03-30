using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Red : MonoBehaviour
{
    public int Pulse;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red Button"))
        {
            Pulse = 1;
        }
    }


}
