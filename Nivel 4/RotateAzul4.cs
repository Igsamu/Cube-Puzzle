using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAzul4 : MonoBehaviour
{
    public Azul4 azul4;

    private void Start()
    {
        azul4 = FindObjectOfType<Azul4>();
    }

    private void Update()
    {
        if (azul4.azu4 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler (0,0,0);
        }
    }
}
