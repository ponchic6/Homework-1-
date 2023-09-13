using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheker : MonoBehaviour
{
    [SerializeField] private SpheresData _spheraData;
    private AbstractWinCondition _winCondition;
    private int countInList;

    public void SetWinCondition1()
    {
        _winCondition = new WinCondition1();
        _winCondition.SpheresData.spheraList = _spheraData.spheraList;
        
        countInList = _spheraData.spheraList.Count;
    }
    public void SetWinCondition2()
    {
        _winCondition = new WinCondition2();
        _winCondition.SpheresData.spheraList = _spheraData.spheraList;
        
        countInList = _spheraData.spheraList.Count;
    }
    
    private void Update()
    {
        if (_winCondition != null)
        {
            if (_spheraData.spheraList.Count == countInList)
                _winCondition.CheckWin();
            countInList = _spheraData.spheraList.Count;
        }
    }
}