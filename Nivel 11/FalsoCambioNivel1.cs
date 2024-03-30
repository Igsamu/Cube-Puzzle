using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FalsoCambioNivel1 : MonoBehaviour
{
    public bool cambio;

    private void Update()
    {
        if(cambio == true)
        {
            SceneManager.LoadScene("Nivel11_2");
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
