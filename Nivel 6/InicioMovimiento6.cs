using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento6 : MonoBehaviour
{
    public Movement movement6;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement6.enabled = true;
        }
    }
}
