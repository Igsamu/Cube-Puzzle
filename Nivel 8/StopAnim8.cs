using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim8 : MonoBehaviour
{
    public Animator anim8;
    void Update()
    {
        if (gameObject.transform.position.y <= 0)
        {
            anim8.enabled = false;
        }
    }
}
