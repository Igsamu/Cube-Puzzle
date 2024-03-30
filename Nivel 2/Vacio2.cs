using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio2 : MonoBehaviour
{
    public Movement movement2;
    public InicioMovimiento2 inicioMovimiento2;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inicioMovimiento2.enabled = false;
            movement2.enabled = false;
            audioSource.Play();
        }
    }
}
