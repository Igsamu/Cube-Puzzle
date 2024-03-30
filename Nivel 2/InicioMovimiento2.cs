using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento2 : MonoBehaviour
{
    public Movement movement2;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement2.enabled = true;
        }
    }
}
