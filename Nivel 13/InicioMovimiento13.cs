using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento13 : MonoBehaviour
{
    public Movement1 movement13;
    public bool cam;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement13.enabled = true;
            cam = true;
        }
    }
}
