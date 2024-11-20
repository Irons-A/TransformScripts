using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour
{
    private float _growRateValue = 0.5f;
    private float _rotationSpeed = 80f;
    private float _moveSpeed = 1.5f;

    void Update()
    {
        float growRate = _growRateValue * Time.deltaTime;

        transform.localScale += new Vector3(growRate, growRate, growRate);
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        transform.position += transform.forward * _moveSpeed * Time.deltaTime;
    }
}
