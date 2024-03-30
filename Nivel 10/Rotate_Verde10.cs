using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Verde10 : MonoBehaviour
{
    public Verde10 verde10;

    void Start()
    {
        verde10 = FindObjectOfType<Verde10>();
    }

    private void Update()
    {
        if (verde10.ver10 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (verde10.ver10 == false)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }
}
