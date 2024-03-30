using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel5 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -70)
        {
            SceneManager.LoadScene("Nivel10_1");
        }
    }
}
