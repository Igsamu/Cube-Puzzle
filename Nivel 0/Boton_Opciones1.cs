using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton_Opciones1 : MonoBehaviour
{
    public EfectoEscritura0_2 EE2;
    public Button boton;

    private void Start()
    {
        EE2 = GetComponent<EfectoEscritura0_2>();
        boton.onClick.AddListener(Escrito2);
    }

    void Escrito2()
    {
        EE2.enabled = true;
    }
}
