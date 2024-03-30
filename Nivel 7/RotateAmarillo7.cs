using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAmarillo7 : MonoBehaviour
{
    public Amarillo7 amarillo7;

    private void Start()
    {
        amarillo7 = FindObjectOfType<Amarillo7>();
    }

    private void Update()
    {
        if (amarillo7.ama7 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
