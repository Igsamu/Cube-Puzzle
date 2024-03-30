using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScena11 : MonoBehaviour
{
    void Update()
    {
        if(gameObject.transform.position.y <= -46)
        {
            SceneManager.LoadScene("Nivel12");
        }
    }
}
