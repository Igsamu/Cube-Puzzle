using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento7 : MonoBehaviour
{
    public Movement movement7;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement7.enabled = true;
        }
    }
}
