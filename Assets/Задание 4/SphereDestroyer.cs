using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SphereDestroyer : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpheresData spheresData;
    private Vector3 pos;
    private RaycastHit _hit;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out _hit))
            {
                RemoveAndDestroySphere(_hit);
            }
                
        }
    }

    private void RemoveAndDestroySphere(RaycastHit hit)
    {
        spheresData.spheraList.Remove(hit.collider.gameObject);
        Destroy(hit.collider.gameObject);
    }
}
