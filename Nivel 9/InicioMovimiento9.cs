using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento9 : MonoBehaviour
{
    public Movement movement9;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement9.enabled = true;
        }
    }
}
