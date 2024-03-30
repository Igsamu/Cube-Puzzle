using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final8 : MonoBehaviour
{
    public Negro8 negro8;
    public Rigidbody rb8;
    public Reinicio8 reinicio8;

    private void Start()
    {
        negro8 = FindObjectOfType<Negro8>();
    }

    private void Update()
    {
        if(negro8.neg8 == true)
        {
            rb8.constraints = RigidbodyConstraints.None;
            reinicio8.enabled = false;
        }
    }
}
