using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleGrow : MonoBehaviour
{
    public float growSpeed = 1f;

    private void Update()
    {
        transform.localScale += Vector3.one * growSpeed * Time.deltaTime;
    }
}
