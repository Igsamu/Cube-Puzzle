using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNegro7 : MonoBehaviour
{
    public Negro7 negro7;

    private void Start()
    {
        negro7 = FindObjectOfType<Negro7>();
    }

    private void Update()
    {
        if(negro7.neg7 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
