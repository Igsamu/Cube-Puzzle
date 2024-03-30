using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaNegro9 : MonoBehaviour
{
    public Negro9 negro9;
    public Rigidbody rb;
    void Start()
    {
        negro9 = FindObjectOfType<Negro9>();
    }

    // Update is called once per frame
    void Update()
    {
        if (negro9.neg9 == true)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
