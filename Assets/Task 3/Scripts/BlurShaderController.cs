using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlurShaderController : MonoBehaviour
{
    public Material blurMaterial;
    public Slider focusRadiusSlider;
    public Slider blurStrengthSlider;
    public Toggle nightVisionToggle;
    public Color nightVisionColor = Color.green;

    void Start()
    {
        focusRadiusSlider.onValueChanged.AddListener(value => blurMaterial.SetFloat("_FocusRadius", value));
        blurStrengthSlider.onValueChanged.AddListener(value => blurMaterial.SetFloat("_BlurStrength", value));
        nightVisionToggle.onValueChanged.AddListener(value => blurMaterial.SetFloat("_NightVisionToggle", value ? 1f : 0f));
        blurMaterial.SetColor("_NightVisionColor", nightVisionColor);
    }
}
