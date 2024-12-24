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

            // Adjust the position of the plane to move from right to left
            Vector3 newPosition = _healthBarPlane.localPosition;
            newPosition.x = -(1f - _healthValue) * 0.5f; // Offset by half the shrinkage
            _healthBarPlane.localPosition = newPosition;
        }
    }
}
