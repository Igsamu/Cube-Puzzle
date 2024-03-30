using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Rojo11 : MonoBehaviour
{
    public Rojo11 rojo11;

    void Start()
    {
        rojo11 = FindObjectOfType<Rojo11>();
    }

    private void Update()
    {
        if (rojo11.roj11 == true)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (rojo11.roj11 == false)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }
    }
}
