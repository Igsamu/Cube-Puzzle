using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel8 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -30)
        {
            SceneManager.LoadScene("Nivel9");
        }
    }
}
