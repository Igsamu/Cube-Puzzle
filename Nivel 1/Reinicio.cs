using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (gameObject.transform.position.y <= -10 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel1");
        }
    }
}
