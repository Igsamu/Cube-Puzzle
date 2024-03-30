using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNegro8 : MonoBehaviour
{
    public Negro8 negro8;

    private void Start()
    {
        negro8 = FindObjectOfType<Negro8>();
    }

    private void Update()
    {
        if(negro8.neg8 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
