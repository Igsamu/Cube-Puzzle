using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Rojo10 : MonoBehaviour
{
    public Rojo10 rojo10;

    void Start()
    {
        rojo10 = FindObjectOfType<Rojo10>();
    }

    private void Update()
    {
        if (rojo10.roj10 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (rojo10.roj10 == false)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }
}
