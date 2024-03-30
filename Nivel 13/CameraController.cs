using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerTransform;
    public Vector3 offset;

    private void Start()
    {
        offset = transform.position - playerTransform.transform.position;
    }
    void Update()
    {
        transform.position = playerTransform.transform.position + offset;
    }
}
