using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    [SerializeField] private Material _healthBarMaterial;
    [Range(0, 1)][SerializeField] private float _healthValue;
    [SerializeField] private Transform _healthBarPlane;

    void Update()
    {
        if (_healthBarPlane != null)
        {
            _healthBarMaterial.SetFloat("_HealthValue", _healthValue);
            Vector3 newScale = _healthBarPlane.localScale;
            newScale.x = _healthValue; // Adjust the X-scale according to health
            _healthBarPlane.localScale = newScale;
        }
    }
}
