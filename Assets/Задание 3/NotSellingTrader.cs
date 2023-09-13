using UnityEngine;

public class NotSellingTrader : BaseTrader
{
    public override void Trade()
    {
        Debug.Log("Ничем не торгую");
    }
}