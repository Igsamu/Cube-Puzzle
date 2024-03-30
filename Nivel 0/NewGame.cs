using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{
    public Button boton;

    void Start()
    {
        boton.onClick.AddListener(CargarNivel1);
    }

    void CargarNivel1()
    {
        SceneManager.LoadScene("Nivel1");
    }
}
