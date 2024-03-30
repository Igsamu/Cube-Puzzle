using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim11 : MonoBehaviour
{
    public Animator anim11;
    void Update()
    {
        if (gameObject.transform.position.y <= 0)
        {
            anim11.enabled = false;
        }
    }
}
