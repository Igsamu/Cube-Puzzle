using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio10 : MonoBehaviour
{
    public Movement movement10;
    public InicioMovimiento10 inicioMovimiento10;
    public AudioSource audioSource;

    private void Start()
    {
        movement10 = FindObjectOfType<Movement>();
        inicioMovimiento10 = FindObjectOfType<InicioMovimiento10>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            movement10.enabled = false;
            inicioMovimiento10.enabled = false;
            audioSource.Play();
        }
    }
}
