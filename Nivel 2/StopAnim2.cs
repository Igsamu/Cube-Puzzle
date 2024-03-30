using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim2 : MonoBehaviour
{
    public Animator anim2;
    void Update()
    {
        if (gameObject.transform.position.y <= 0)
        {
            anim2.enabled = false;
        }
    }
}
