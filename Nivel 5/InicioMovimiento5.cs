using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioMovimiento5 : MonoBehaviour
{
    public Movement movement5;

    private void Update()
    {
        if(gameObject.transform.position.y <= 2)
        {
            movement5.enabled = true;
        }
    }
}
