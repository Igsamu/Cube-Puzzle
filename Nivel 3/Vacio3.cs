using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio3 : MonoBehaviour
{
    public Movement movement3;
    public InicioMovimiento3 inicioMovimiento3;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inicioMovimiento3.enabled = false;
            movement3.enabled = false;
            audioSource.Play();
        }
    }
}
