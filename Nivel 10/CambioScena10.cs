using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScena10 : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y == -40)
        {
            SceneManager.LoadScene("Nivel11");
        }
    }
}
