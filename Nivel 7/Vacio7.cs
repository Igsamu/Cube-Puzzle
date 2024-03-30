using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio7 : MonoBehaviour
{
    public Movement movement7;
    public InicioMovimiento7 inicioMovimiento7;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inicioMovimiento7.enabled = false;
            movement7.enabled = false;
            audioSource.Play();
        }
    }
}
