using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarVacioNegro : MonoBehaviour
{
    public Negro9 negro9;
    public float x;
    public float z;

    private void Start()
    {
        negro9 = FindObjectOfType<Negro9>();
        x = transform.position.x;
        z = transform.position.z;
    }

    private void Update()
    {
        if(negro9.neg9 == true)
        {
            transform.position = new Vector3(x, 1, z);
        }
    }
}
