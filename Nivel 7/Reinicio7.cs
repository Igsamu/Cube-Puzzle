using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio7 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -50 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel7");
        }
    }
}
