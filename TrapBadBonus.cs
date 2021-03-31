using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBadBonus : InteractiveObject
{
    protected override void Interaction()
    {
        Player.hp = 0;
        Debug.Log(Player.hp);
    }

}
