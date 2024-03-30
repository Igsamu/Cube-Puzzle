using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel9 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -40)
        {
            SceneManager.LoadScene("Nivel10");
        }
    }
}
