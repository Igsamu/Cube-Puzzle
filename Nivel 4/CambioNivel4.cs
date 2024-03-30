using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel4 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -100)
        {
            SceneManager.LoadScene("Nivel5");
        }
    }
}
