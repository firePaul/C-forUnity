using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

public class AmmoBonus : InteractiveObject, IRotation
{
    private float _speedRotation = 30f;

    protected override void Interaction()
    {
        Player.ammo += 20;
        Log($"� ��� { Player.ammo} ��������");
        Destroy(gameObject);
    }

    public void Rotation()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
    }
}
