using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio13 : MonoBehaviour
{
    public Movement1 movement13;
    public InicioMovimiento13 inicioMovimiento13;
    public AudioSource audioSource;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            inicioMovimiento13.enabled = false;
            movement13.enabled = false;
            audioSource.Play();
        }
    }
}
