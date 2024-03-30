using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim10_1 : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        if (gameObject.transform.position.y <= 0)
        {
            anim.enabled = false;
        }
    }
}
