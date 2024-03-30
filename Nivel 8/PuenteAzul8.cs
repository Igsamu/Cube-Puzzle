using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuenteAzul8 : MonoBehaviour
{
    public Azul8 azul8;
    public GameObject cubePrefab8;

    private void Start()
    {
        azul8 = FindObjectOfType<Azul8>();
    }

    private void Update()
    {
        if(azul8.azu8 == true)
        {
            Instantiate(cubePrefab8, new Vector3(3, 0, 3), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
