using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarVacioAmarillo : MonoBehaviour
{
    public Amarillo9 amarillo9;
    public float x;
    public float z;

    private void Start()
    {
        amarillo9 = FindObjectOfType<Amarillo9>();
        x = transform.position.x;
        z = transform.position.z;
    }

    private void Update()
    {
        if(amarillo9.ama9 == true)
        {
            transform.position = new Vector3(x, 1, z);
        }
    }
}
