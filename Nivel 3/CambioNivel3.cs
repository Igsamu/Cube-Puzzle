using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel3 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -35)
        {
            SceneManager.LoadScene("Nivel4");
        }
    }
}
