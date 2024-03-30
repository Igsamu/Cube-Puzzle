using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAmarillo5 : MonoBehaviour
{
    public Amarillo5 amarillo5;

    private void Start()
    {
        amarillo5 = FindObjectOfType<Amarillo5>();
    }

    private void Update()
    {
        if (amarillo5.ama5 == 1)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
