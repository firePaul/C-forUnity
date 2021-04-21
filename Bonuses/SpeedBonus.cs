using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

public class SpeedBonus : InteractiveObject, IRotation
{
    private int _multiply = 3;
    //private float _duration = 3f;
    private float _speedRotation = 30f;
    public  delegate void BonusTrigerred();

    public BonusTrigerred Triggered;
    
    protected override void Interaction()
    {
        Player.speed = Player.speed*_multiply;
        Log(Player.speed);
        Triggered();
        Destroy(gameObject);

    }
    public void Rotation()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
    }
}
