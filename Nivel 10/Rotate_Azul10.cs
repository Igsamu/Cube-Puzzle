using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Azul10 : MonoBehaviour
{
    public Azul10 azul10;

    void Start()
    {
        azul10 = FindObjectOfType<Azul10>();
    }

    private void Update()
    {
        if (azul10.azu10 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (azul10.azu10 == false)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }
}
