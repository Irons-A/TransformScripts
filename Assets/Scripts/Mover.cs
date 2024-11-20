using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _moveSpeed = 1.5f;

    private void Update()
    {
        transform.position += transform.forward * _moveSpeed * Time.deltaTime;
    }
}
