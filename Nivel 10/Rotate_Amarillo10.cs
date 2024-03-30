using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Amarillo10 : MonoBehaviour
{
    public Amarillo10 amarillo10;

    void Start()
    {
        amarillo10 = FindObjectOfType<Amarillo10>();
    }

    private void Update()
    {
        if (amarillo10.ama10 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (amarillo10.ama10 == false)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }
}
