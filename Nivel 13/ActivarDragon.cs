using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDragon : MonoBehaviour
{
    public Dragon dragon;
    public EfectoEscritura13_1 EE;

    void Start()
    {
        dragon = FindObjectOfType<Dragon>();
        EE = FindObjectOfType<EfectoEscritura13_1>();
    }

    private void Update()
    {
        if(dragon.drag == true)
        {
            EE.enabled = true;
        }
    }


}
