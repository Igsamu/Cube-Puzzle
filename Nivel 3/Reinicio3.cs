using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio3 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -25 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel3");
        }
    }
}
