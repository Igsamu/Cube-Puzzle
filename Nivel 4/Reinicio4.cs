using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio4 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -80 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel4");
        }
    }
}
