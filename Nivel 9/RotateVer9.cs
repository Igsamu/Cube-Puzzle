using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVer9 : MonoBehaviour
{
    public Rojo9 rojo9;
    private void Start()
    {
        rojo9 = FindObjectOfType<Rojo9>();
    }

    private void Update()
    {
        if(rojo9.roj9 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90,0,0);
        }
    }
}
