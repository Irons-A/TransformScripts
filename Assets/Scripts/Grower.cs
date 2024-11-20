using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _growRateValue = 0.5f;

    private void Update()
    {
        float growRate = _growRateValue * Time.deltaTime;

        transform.localScale += new Vector3(growRate, growRate, growRate);
    }
}
