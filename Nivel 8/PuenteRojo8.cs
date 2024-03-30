using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuenteRojo8 : MonoBehaviour
{
    public Rojo8 rojo8;
    public GameObject CubePrefab8;

    private void Start()
    {
        rojo8 = FindObjectOfType<Rojo8>();
    }

    private void Update()
    {
        if(rojo8.roj8 == true)
        {
            Instantiate(CubePrefab8, new Vector3(11, 0, 3), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
