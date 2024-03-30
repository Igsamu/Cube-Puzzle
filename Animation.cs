using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator anim;
    void Start()
    {

    }
    void Update()
    {
        if  (gameObject.transform.position.y <= -1)
        {
            anim.enabled = false;
        }
    }
}