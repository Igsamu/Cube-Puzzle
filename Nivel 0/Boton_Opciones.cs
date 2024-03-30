using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton_Opciones : MonoBehaviour
{
    public EfectoEscritura0_1 EE;
    public Button boton;

    private void Start()
    {
        EE = GetComponent<EfectoEscritura0_1>();
        boton.onClick.AddListener(Escrito);
    }

    void Escrito()
    {
        EE.enabled = true;
    }
}
