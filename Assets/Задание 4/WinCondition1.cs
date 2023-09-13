using UnityEngine;

public class WinCondition1 : AbstractWinCondition
{
    public override void CheckWin()
    {
        if (SpheresData.spheraList.Count == 0)
        {
            Debug.Log("Win");
        }
    }
}