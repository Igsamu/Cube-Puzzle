using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim7 : MonoBehaviour
{
    public Animator anim7;
    void Update()
    {
        if (gameObject.transform.position.y <= 0)
        {
            anim7.enabled = false;
        }
    }
}
