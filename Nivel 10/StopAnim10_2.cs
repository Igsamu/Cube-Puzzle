using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim10_2 : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        if (gameObject.transform.position.y <= 4)
        {
            anim.enabled = false;
        }
    }
}
