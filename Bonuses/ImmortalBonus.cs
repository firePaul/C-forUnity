using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmortalBonus : InteractiveObject, IRotation
{
    //private float _duration = 3f;
    private float _speedRotation = 30f;
    private const float _imhp=300;
    private float _curhp;

    protected override void Interaction()
    {
        _curhp = Player.hp;
        Player.hp=_imhp;
        Destroy(gameObject);
    }

    public void Rotation()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
    }
}
