using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNegro6 : MonoBehaviour
{
    public Negro6 negro6;

    private void Start()
    {
        negro6 = FindObjectOfType<Negro6>();
    }

    private void Update()
    {
        if (negro6.neg6 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
