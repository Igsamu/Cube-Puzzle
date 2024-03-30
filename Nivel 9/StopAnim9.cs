using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim9 : MonoBehaviour
{
    public Animator anim9;
    void Update()
    {
        if (gameObject.transform.position.y <= 0)
        {
            anim9.enabled = false;
        }
    }
}
