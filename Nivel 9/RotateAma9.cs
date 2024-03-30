using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAma9 : MonoBehaviour
{
    public Negro9 negro9;
    void Start()
    {
        negro9 = FindObjectOfType<Negro9>();
    }

    // Update is called once per frame
    void Update()
    {
        if(negro9.neg9 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }
}
