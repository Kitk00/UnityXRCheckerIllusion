using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaChange : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    [SerializeField] private Renderer myModel;

    private void Start()
    {
        
    }
    public void AlphaSlider(float sliderValue)
    {
        Color color = myModel.material.color;
        color.a = sliderValue;
        myModel.material.color = color;
    }

    private void OnDestroy()
    {
        Destroy(myModel.material);
    }

}
