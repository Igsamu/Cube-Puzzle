using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAzul5 : MonoBehaviour
{
    public Azul5 azul5;

    private void Start()
    {
        azul5 = FindObjectOfType<Azul5>();
    }

    private void Update()
    {
        if (azul5.azu5 == 1)
        {
            gameObject.transform.rotation = Quaternion.Euler (0,0,0);
        }
    }
}
