using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRojo7 : MonoBehaviour
{
    public Rojo7 rojo7;

    private void Start()
    {
        rojo7 = FindObjectOfType<Rojo7>();
    }

    private void Update()
    {
        if (rojo7.roj7 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
