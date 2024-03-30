using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (gameObject.transform.position.y <= -30)
        {
            SceneManager.LoadScene("Nivel2");
        }
    }


}
