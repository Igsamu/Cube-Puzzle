using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio6 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -35 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel6");
        }
    }
}
