using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeComplex : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 90f;
    public float growSpeed = 1f;

    private void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        transform.localScale += Vector3.one * growSpeed * Time.deltaTime;
    }
}
