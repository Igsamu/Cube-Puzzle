using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel2 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -15)
        {
            SceneManager.LoadScene("Nivel3");
        }
    }
}
