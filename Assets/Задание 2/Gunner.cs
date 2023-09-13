using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunner : MonoBehaviour
{
    private AbstractGun _abstractGun;

    private void Awake()
    {
        SetGunByDefolt();
    }

    private void SetGunByDefolt()
    {
        _abstractGun = new Gun1();
    }

    private void Update()
    {
        SetGun();
        
        if (Input.GetButtonDown("Fire1"))
        {
            _abstractGun.Shot();
        }
    }

    private void SetGun()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _abstractGun = new Gun1();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _abstractGun = new Gun2();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _abstractGun = new Gun3();
        }
    }
}