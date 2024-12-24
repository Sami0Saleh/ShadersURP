using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    [SerializeField] private Material _flagMaterial;
    [Range(0, 10)] [SerializeField] private float _windStrength = 1f; 
    [Range(0, 10)] [SerializeField] private float _windSpeed = 1f; 

    void Update()
    {
        _flagMaterial.SetFloat("_WindStrength", _windStrength);
        _flagMaterial.SetFloat("_WindSpeed", _windSpeed);
    }
}