using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puente2_11 : MonoBehaviour
{
    public GameObject CubePrefab11;
    public Amarillo11 amarillo11;
    public Azul11 azul11;
    public Rojo11 rojo11;

    private void Start()
    {
        amarillo11 = FindObjectOfType<Amarillo11>();
        azul11 = FindObjectOfType<Azul11>();
        rojo11 = FindObjectOfType<Rojo11>();
    }

    private void Update()
    {
        if (amarillo11.ama11 == true && azul11.azu11 == true && rojo11.roj11 == true)
        {
            Instantiate(CubePrefab11, new Vector3(9, 0, 9), Quaternion.identity);
            Instantiate(CubePrefab11, new Vector3(9, 0, 7), Quaternion.identity);
            Instantiate(CubePrefab11, new Vector3(9, 0, 11), Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
