using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio5_2 : MonoBehaviour
{
    public Movement movement;
    public InicioMovimiento5 inicioMovimiento5;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inicioMovimiento5.enabled = false;
            movement.enabled = false;
            audioSource.Play();
        }
    }
}
