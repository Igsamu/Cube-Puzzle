using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAmarillo6 : MonoBehaviour
{
    public Amarillo6 amarillo6;

    private void Start()
    {
        amarillo6 = FindObjectOfType<Amarillo6>();
    }

    private void Update()
    {
        if (amarillo6.ama6 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
