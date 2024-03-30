using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento3 : MonoBehaviour
{
    public Movement movement3;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement3.enabled = true;
        }
    }
}
