using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarVacioAzul : MonoBehaviour
{
    public Azul9 azul9;
    public float x;
    public float z;

    private void Start()
    {
        azul9 = FindObjectOfType<Azul9>();
        x = transform.position.x;
        z = transform.position.z;
    }
    private void Update()
    {
        if(azul9.azu9 == true)
        {
            transform.position = new Vector3(x, 1, z);
        }
    }
}
