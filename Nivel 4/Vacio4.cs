using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio4 : MonoBehaviour
{
    public Movement movement4;
    public InicioMovimiento4 inicioMovimiento4;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inicioMovimiento4.enabled = false;
            movement4.enabled = false;
            audioSource.Play();
        }
    }
}
