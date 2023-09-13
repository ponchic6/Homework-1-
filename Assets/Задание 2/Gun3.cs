using UnityEngine;

public class Gun3 : AbstractGun
{
    public Gun3()
    {
        bulletCount = 30;
        shotsByCLick = 3;
    }
    public override void Shot()
    {
        if (bulletCount - 3 >= 0)
        {
            bulletCount -= shotsByCLick;
            Debug.Log($"Выстрелил {shotsByCLick} за раз, патронов осталось {bulletCount}");
        }
        else
        {
            Debug.Log("Патронов нет...");
        }
    }
}