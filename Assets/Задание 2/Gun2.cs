using UnityEngine;

public class Gun2 : AbstractGun
{
    public override void Shot()
    {
        Debug.Log("Выстрелил 1 один раз, патронов бесконечно");
    }
}