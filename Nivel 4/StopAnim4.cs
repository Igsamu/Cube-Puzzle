using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim4 : MonoBehaviour
{
    public Animator anim4;
    void Update()
    {
        if (gameObject.transform.position.y <= 0)
        {
            anim4.enabled = false;
        }
    }
}
