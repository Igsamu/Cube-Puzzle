using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio5_1 : MonoBehaviour
{
    public GameObject CubePrefab5;
    public Amarillo5 amarillo5;
    public Azul5 azul5;
    public Movement movement;
    public InicioMovimiento5 inicioMovimiento5;
    public AudioSource audioSource;

    private void Start()
    {
        amarillo5 = FindObjectOfType<Amarillo5>();
        azul5 = FindObjectOfType<Azul5>();
    }

    private void Update()
    {
        if (amarillo5.ama5 == 1 && azul5.azu5 == 1)
        {
            Instantiate(CubePrefab5, new Vector3(1, -1, -3), Quaternion.identity);
            Instantiate(CubePrefab5, new Vector3(1, -1, -1), Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inicioMovimiento5.enabled = false;
            movement.enabled = false;
            audioSource.Play();
        }
    }
}
