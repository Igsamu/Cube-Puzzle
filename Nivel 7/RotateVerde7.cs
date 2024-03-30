using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVerde7 : MonoBehaviour
{
    public Verde7 verde7;

    private void Start()
    {
        verde7 = FindObjectOfType<Verde7>();
    }

    private void Update()
    {
        if(verde7.ver7 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
