using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractWinCondition
{
    public SpheresData SpheresData = new SpheresData();
    public abstract void CheckWin();
}