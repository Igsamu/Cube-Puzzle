using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAmarillo4 : MonoBehaviour
{
    public Amarillo4 amarillo4;

    private void Start()
    {
        amarillo4 = FindObjectOfType<Amarillo4>();
    }

    private void Update()
    {
        if (amarillo4.ama4 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
