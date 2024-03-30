using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public bool isRolling;
    public float rotateSpeed;
    public AudioSource audioSource;

    private Bounds bound;
    private Vector3 left, right, up, down;

    private void Start()
    {
        bound = GetComponent<BoxCollider>().bounds;
        //left = new Vector3(-bound.size.x/2, -bound.size.y/2, 0);
        right = new Vector3(bound.size.x / 2, -bound.size.y / 2, 0);
        //up = new Vector3(0, -bound.size.y / 2, bound.size.z/2);
        //down = new Vector3(0, -bound.size.y / 2, -bound.size.z/2);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) && !isRolling)
        {
            StartCoroutine(Roll(left));
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.D) && !isRolling)
        {
            StartCoroutine(Roll(right));
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.W) && !isRolling)
        {
            StartCoroutine(Roll(up));
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.S) && !isRolling)
        {
            StartCoroutine(Roll(down));
            audioSource.Play();
        }
    }

    IEnumerator Roll (Vector3 positionToRotation)
    {
        isRolling = true;
        float angle = 0;
        Vector3 point = transform.position + positionToRotation;
        Vector3 axis = Vector3.Cross(Vector3.up, positionToRotation).normalized;

        while ( angle < 90f)
        {
            float angleSpeed = Time.deltaTime + rotateSpeed;
            transform.RotateAround ( point,axis,angleSpeed);
            angle += angleSpeed;
            yield return null;
        }

        transform.RotateAround(point,axis, 90 - angle);

        isRolling = false;
    }
}
