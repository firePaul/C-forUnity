using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

public class SpeedBonus : InteractiveObject, IRotation
{
    private int _multiply = 3;
    private float _duration = 3f;
    private float _speedRotation = 30f;

    protected override void Interaction()
    {
        Player.speed = Player.speed*_multiply;
        Log(Player.speed);
        Invoke("ResetSpeed", _duration);
        Destroy(gameObject);

    }

    void ResetSpeed()
    {
        Player.speed = Player.speed / _multiply;
        Log(Player.speed);       
    }


    public void Rotation()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
    }
}
