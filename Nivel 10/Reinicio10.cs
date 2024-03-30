using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio10 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -19 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel10");
        }
    }
}
