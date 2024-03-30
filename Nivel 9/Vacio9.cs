using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio9 : MonoBehaviour
{
    public Movement movement9;
    public InicioMovimiento9 inicioMovimiento9;
    public AudioSource audioSource;

    private void Start()
    {
        movement9 = FindObjectOfType<Movement>();
        inicioMovimiento9 = FindObjectOfType<InicioMovimiento9>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            movement9.enabled = false;
            inicioMovimiento9.enabled = false;
            audioSource.Play();
        }
    }
}
