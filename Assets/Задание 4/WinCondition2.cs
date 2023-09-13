using UnityEngine;

public class WinCondition2 : AbstractWinCondition
{
    private int _red;
    private int _green;
    private int _white;
    
    private void UpdateColorInfo()
    {    
        _green = 0;
        _red = 0;
        _white = 0;
        foreach (var sphere in SpheresData.spheraList)
        {
            var color = sphere.GetComponent<SphereType>()._color;
            if (color == SphereType.color.green)
                _green += 1;
            if (color == SphereType.color.red)
                _red += 1;
            if (color == SphereType.color.white)
                _white += 1;
        }
    }

    public override void CheckWin()
    {
        UpdateColorInfo();
        if (_red == 0 || _green == 0 || _white == 0)
        {
            Debug.Log("Win");
        }
    }
}