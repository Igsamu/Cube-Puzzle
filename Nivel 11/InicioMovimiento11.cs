using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento11 : MonoBehaviour
{
    public Movement movement11;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement11.enabled = true;
        }
    }
}
