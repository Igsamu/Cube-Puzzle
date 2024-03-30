using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio11 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -40 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel11");
        }
    }
}
