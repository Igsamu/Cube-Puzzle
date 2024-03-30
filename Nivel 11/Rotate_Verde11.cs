using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Verde11 : MonoBehaviour
{
    public Verde11 verde11;

    void Start()
    {
        verde11 = FindObjectOfType<Verde11>();
    }

    private void Update()
    {
        if (verde11.ver11 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (verde11.ver11 == false)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }
}
