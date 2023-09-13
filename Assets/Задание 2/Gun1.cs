using UnityEngine;

public class Gun1 : AbstractGun
{
    public Gun1()
    {
        shotsByCLick = 1;
        bulletCount = 10;
    }
    public override void Shot()
    {
        if (bulletCount != 0)
        {
            bulletCount -= shotsByCLick;                                                            
            Debug.Log($"Выстрелил {shotsByCLick} раз, патронов осталось {bulletCount}"); 
        }

        else
        {
            Debug.Log("Патроны кончились...");
        }
    }
}