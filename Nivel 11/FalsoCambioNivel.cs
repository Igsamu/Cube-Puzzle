using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FalsoCambioNivel : MonoBehaviour
{
    public bool cambio;

    private void Update()
    {
        if(cambio == true)
        {
            SceneManager.LoadScene("Nivel11_1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cambio = true;
        }
    }
}
