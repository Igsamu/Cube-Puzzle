using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuenteAmarillo8 : MonoBehaviour
{
    public Amarillo8 amarillo8;
    public GameObject CubePrefab8;

    private void Start()
    {
        amarillo8 = FindObjectOfType<Amarillo8>();
    }

    private void Update()
    {
        if(amarillo8.ama8 == true)
        {
            Instantiate(CubePrefab8, new Vector3(-5, 0, 3), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
