using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento : MonoBehaviour
{
    public Movement movement;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement.enabled = true;
        }
    }
}
