using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShaderController : MonoBehaviour
{
    public Material toonMaterial;
    public Slider bandSlider;
    public Toggle phongToggle;

    void Start()
    {
        bandSlider.onValueChanged.AddListener(value => toonMaterial.SetFloat("_NumberOfBands", value));
        phongToggle.onValueChanged.AddListener(value => toonMaterial.SetFloat("_UsePhong", value ? 1f : 0f));
    }
}
