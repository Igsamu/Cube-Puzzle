using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio8 : MonoBehaviour
{
    public Movement movement8;
    public InicioMovimiento8 inicioMovimiento8;
    public AudioSource audioSource;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            inicioMovimiento8.enabled = false;
            movement8.enabled = false;
            audioSource.Play();
        }
    }
}
