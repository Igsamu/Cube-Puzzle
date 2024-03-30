using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRojo8 : MonoBehaviour
{
    public Rojo8 rojo8;

    private void Start()
    {
        rojo8 = FindObjectOfType<Rojo8>();
    }

    private void Update()
    {
        if(rojo8.roj8 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
