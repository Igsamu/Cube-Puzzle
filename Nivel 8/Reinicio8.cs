using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio8 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -30 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel8");
        }
    }
}
