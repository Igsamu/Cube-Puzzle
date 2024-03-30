using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio6 : MonoBehaviour
{
    public Movement movement6;
    public InicioMovimiento6 inicioMovimiento6;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inicioMovimiento6.enabled = false;
            movement6.enabled = false;
            audioSource.Play();
        }
    }
}
