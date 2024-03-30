using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRoj9 : MonoBehaviour
{
    public Azul9 azul9;

    private void Start()
    {
        azul9 = FindObjectOfType<Azul9>();
    }

    private void Update()
    {
        if(azul9.azu9 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }
}
