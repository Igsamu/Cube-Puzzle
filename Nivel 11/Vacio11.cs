using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio11 : MonoBehaviour
{
    public Movement movement11;
    public InicioMovimiento11 inicioMovimiento11;
    public AudioSource audioSource;

    private void Start()
    {
        movement11 = FindObjectOfType<Movement>();
        inicioMovimiento11 = FindObjectOfType<InicioMovimiento11>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            movement11.enabled = false;
            inicioMovimiento11.enabled = false;
            audioSource.Play();
        }
    }
}
