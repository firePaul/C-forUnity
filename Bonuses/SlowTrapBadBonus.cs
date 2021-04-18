using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

public class SlowTrapBadBonus : InteractiveObject
{
    private int _multiply = 3;
    private float _duration = 3f;
    public  delegate void BadBonusTrigerred();

    public BadBonusTrigerred BadTrigerred;
    protected override void Interaction()
    {
        Player.speed = Player.speed / _multiply;
        Log(Player.speed);
        BadTrigerred();
        Invoke("ResetSpeed", _duration);
    }

    void ResetSpeed()
    {
        Player.speed = Player.speed * _multiply;
        Log(Player.speed);
    }

}
