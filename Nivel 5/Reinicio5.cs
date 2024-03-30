using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio5 : MonoBehaviour
{
    private void Start()
    {
        
    }
    void Update()
    {
        if (gameObject.transform.position.y <= -20 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel5_1");
        }
    }
}
