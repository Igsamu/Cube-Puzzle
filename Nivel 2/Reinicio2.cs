using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio2 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -20 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel2_1");
        }
    }
}
