using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAmarillo8 : MonoBehaviour
{
    public Amarillo8 amarillo8;

    private void Start()
    {
        amarillo8 = FindObjectOfType<Amarillo8>();
    }

    private void Update()
    {
        if(amarillo8.ama8 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
