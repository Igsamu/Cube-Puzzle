using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Azul11 : MonoBehaviour
{
    public Azul11 azul11;

    void Start()
    {
        azul11 = FindObjectOfType<Azul11>();
    }

    private void Update()
    {
        if (azul11.azu11 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (azul11.azu11 == false)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }
}
