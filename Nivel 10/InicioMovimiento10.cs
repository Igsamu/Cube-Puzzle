using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento10 : MonoBehaviour
{
    public Movement movement10;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement10.enabled = true;
        }
    }
}
