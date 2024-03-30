using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim6 : MonoBehaviour
{
    public Animator anim6;
    void Update()
    {
        if (gameObject.transform.position.y <= 0)
        {
            anim6.enabled = false;
        }
    }
}
