using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

public class HPBonus : InteractiveObject, IRotation
{
    private float _speedRotation = 30f;

    protected override void Interaction()
    {
        Player.hp += 50;
        Log($"� ��� { Player.hp} ����� ��������");
        Destroy(gameObject);
    }

    public void Rotation()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
    }
}
