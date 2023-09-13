using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseTrader : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Trade();
    }

    public abstract void Trade();
}