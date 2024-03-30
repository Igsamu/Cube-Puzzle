using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim3 : MonoBehaviour
{
    public Animator anim3;
    void Update()
    {
        if (gameObject.transform.position.y <= 0)
        {
            anim3.enabled = false;
        }
    }
}
