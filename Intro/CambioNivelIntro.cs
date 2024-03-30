using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivelIntro : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            SceneManager.LoadScene("Nivel0");
        }
    }
}
