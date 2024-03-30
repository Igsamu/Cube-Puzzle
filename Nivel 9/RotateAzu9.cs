using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAzu9 : MonoBehaviour
{
    public Amarillo9 amarillo9;

    private void Start()
    {
        amarillo9 = FindObjectOfType<Amarillo9>();
    }

    private void Update()
    {
        if (amarillo9.ama9 ==  true)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90,0,0);
        }
    }
}
