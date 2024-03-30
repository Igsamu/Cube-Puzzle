using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final9: MonoBehaviour
{
    public Verde9 verde9;
    public Movement movement9;
    public Reinicio9 reinicio9;
    private void Start()
    {
        verde9 = FindObjectOfType<Verde9>();
        movement9 = FindObjectOfType<Movement>();
        reinicio9 = FindObjectOfType<Reinicio9>();
    }
    private void Update()
    {
        if(verde9.ver9 == true)
        {
            movement9.enabled = false;
            reinicio9.enabled = false;
        }
    }
}
