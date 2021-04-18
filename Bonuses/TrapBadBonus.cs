using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBadBonus : InteractiveObject
{
    public  delegate void TheEnd();

    public TheEnd End;
    protected override void Interaction()
    {
        Player.hp = 0;
        End();
        Debug.Log(Player.hp);
    }

}
