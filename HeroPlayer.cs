using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public sealed class HeroPlayer : Player
{
    private Rigidbody _rigidbody;
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        _rigidbody = GetComponent<Rigidbody>();
        renderer.material.color = Color.green;
    }
        
    public override void Move(float x, float y, float z)
    {
        _rigidbody.AddForce(new Vector3(x, y, z) * speed);
    }
}

