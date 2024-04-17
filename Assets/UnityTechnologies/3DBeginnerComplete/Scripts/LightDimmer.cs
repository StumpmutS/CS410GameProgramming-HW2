using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LightDimmer : MonoBehaviour
{
    [SerializeField] private List<Light> lights;
    [SerializeField] private float dimmingSpeed = 10f;
    [SerializeField, Range(0f, 1f)] private float dimmedAmount = .1f;

    private bool _dimLights;
    
    public void DimLights()
    {
        _dimLights = true;
    }

    private void Update()
    {
        if (!_dimLights) return;
        
        foreach (var light in lights)
        {
            light.color = Color.Lerp(light.color, light.color * dimmedAmount, dimmingSpeed * Time.deltaTime);
        }
    }

    private void OnValidate()
    {
        lights = FindObjectsOfType<Light>().ToList();
    }
}