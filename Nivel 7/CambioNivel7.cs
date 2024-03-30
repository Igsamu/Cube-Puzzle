using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel7 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -73)
        {
            SceneManager.LoadScene("Nivel8");
        }
    }
}
