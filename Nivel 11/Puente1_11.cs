using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puente1_11 : MonoBehaviour
{
    //Puente falso

    public GameObject CubePrefab11;
    public Amarillo11 amarillo11;
    public Azul11 azul11;

    private void Start()
    {
        amarillo11 = FindObjectOfType<Amarillo11>();
        azul11 = FindObjectOfType<Azul11>();
    }
    private void Update()
    {
        if(amarillo11.ama11 == true && azul11.azu11 == true)
        {
            Instantiate(CubePrefab11, new Vector3(5, 0, 15), Quaternion.identity);
            Instantiate(CubePrefab11, new Vector3(3, 0, 15), Quaternion.identity);
            Instantiate(CubePrefab11, new Vector3(1, 0, 15), Quaternion.identity);
            Instantiate(CubePrefab11, new Vector3(-1, 0, 15), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
