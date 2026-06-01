using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleGrow : MonoBehaviour
{
    private float _growSpeed = 0.25f;

    private void Update()
    {
        transform.localScale += Vector3.one * _growSpeed * Time.deltaTime;
    }
}
