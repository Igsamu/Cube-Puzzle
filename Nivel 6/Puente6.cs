using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puente6 : MonoBehaviour
{
    public Amarillo6 Amarillo6;
    public Negro6 Negro6;
    public GameObject cubePrefab6;

    private void Start()
    {
        Amarillo6 = FindObjectOfType<Amarillo6>();
        Negro6 = FindObjectOfType<Negro6>();
    }

    private void Update()
    {
        if (Amarillo6.ama6 == true && Negro6.neg6 == true)
        {
            Instantiate(cubePrefab6, new Vector3(1, 0, 3), Quaternion.identity);
            Instantiate(cubePrefab6, new Vector3(1, 0, 5), Quaternion.identity);
            Instantiate(cubePrefab6, new Vector3(1, 0, 7), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
