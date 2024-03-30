using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Amarillo11 : MonoBehaviour
{
    public Amarillo11 amarillo11;

    void Start()
    {
        amarillo11 = FindObjectOfType<Amarillo11>();
    }

    private void Update()
    {
        if (amarillo11.ama11 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (amarillo11.ama11 == false)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }
}
