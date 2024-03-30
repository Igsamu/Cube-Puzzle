using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio : MonoBehaviour
{
    public Movement movement;
    public InicioMovimiento inicioMovimiento;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inicioMovimiento. enabled = false;
            movement.enabled = false;
            audioSource.Play();
        }
    }
}
