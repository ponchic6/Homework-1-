using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereType : MonoBehaviour
{
    public color _color;
    private Material _currentMaterial;
    public enum color
    {
        red,
        white,
        green
    }

    private void Awake()
    {
        _currentMaterial = GetComponent<Renderer>().material;
    }

    private void Start()
    {
        if (_color == color.green)
        {
            _currentMaterial.color = Color.green;
        }
        if (_color == color.red)
        {
            _currentMaterial.color = Color.red;
        }
        if (_color == color.white)
        {
            _currentMaterial.color = Color.white;
        }
        
    }
}
