using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento4 : MonoBehaviour
{
    public Movement movement4;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement4.enabled = true;
        }
    }
}
