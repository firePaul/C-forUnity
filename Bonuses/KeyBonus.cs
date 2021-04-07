using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

public class KeyBonus : InteractiveObject, IRotation
{
    private int _numberofkeys=0;
    private float _speedRotation=30f;

    protected override void Interaction()
    {
        _numberofkeys+=1;
        Log($"У вас { _numberofkeys} ключей");
        Destroy(gameObject);
    }

    public void Rotation()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
    }
}
