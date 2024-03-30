using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarVacioRojo : MonoBehaviour
{
    public Rojo9 rojo9;
    public float x;
    public float z;
    private void Start()
    {
        rojo9 = FindObjectOfType<Rojo9>();
        x = transform.position.x;
        z = transform.position.z;
    }
    private void Update()
    {
        if(rojo9.roj9 == true)
        {
            transform.position = new Vector3(x,1,z);
        }
    }
}
