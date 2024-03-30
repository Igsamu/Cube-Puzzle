using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel6 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -45)
        {
            SceneManager.LoadScene("Nivel7");
        }
    }
}
