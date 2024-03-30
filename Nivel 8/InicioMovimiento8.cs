using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento8 : MonoBehaviour
{
    public Movement movement8;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement8.enabled = true;
        }
    }
}
