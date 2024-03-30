using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAzul7 : MonoBehaviour
{
    public Azul7 azul7;

    private void Start()
    {
        azul7 = FindObjectOfType<Azul7>();
    }

    private void Update()
    {
        if (azul7.azu7 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
