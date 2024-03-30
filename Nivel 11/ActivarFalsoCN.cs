using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarFalsoCN : MonoBehaviour
{
    public FalsoCambioNivel FCN;
    public Amarillo11 amarillo11;
    public Azul11 azul11;

    // Start is called before the first frame update
    void Start()
    {
        FCN = GetComponent<FalsoCambioNivel>();
        amarillo11 = FindObjectOfType<Amarillo11>();
        azul11 = FindObjectOfType<Azul11>();
    }

    // Update is called once per frame
    void Update()
    {
        if(amarillo11.ama11 == true && azul11.azu11 == true)
        {
            FCN.enabled = true;
        }
    }
}
