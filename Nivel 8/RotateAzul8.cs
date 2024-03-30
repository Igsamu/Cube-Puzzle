using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAzul8 : MonoBehaviour
{
    public Azul8 azul8;

    private void Start()
    {
        azul8 =FindObjectOfType<Azul8>();
    }

    private void Update()
    {
        if(azul8.azu8 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
