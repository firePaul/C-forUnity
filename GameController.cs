using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameController : MonoBehaviour
{
    private InteractiveObject[] _interactiveObjects;
    private RandomColor _rndcolor;
    
    
    private void Awake()
    {
        _interactiveObjects = FindObjectsOfType<InteractiveObject>();
        foreach (var o in _interactiveObjects)
        {
            if (o is SpeedBonus speedBonus)
            {
                speedBonus.Triggered += Triggered;
            }
            if (o is SlowTrapBadBonus slow)
            {
                slow.BadTrigerred += Triggered;
                slow.BadTrigerred += BadTriggered;
            }
        }
    }

    private void Triggered()
    {
        Player.renderer.material.color = Random.ColorHSV();
    }
    private void BadTriggered()
    {
        InTrap.InSlowTrap();
    }
    private void Update()
    {
        for (var i = 0; i < _interactiveObjects.Length; i++)
        {
            var interactiveObject = _interactiveObjects[i];

            if (interactiveObject == null)
            {
                continue;
            }

            if (interactiveObject is IRotation rotation)
            {
                rotation.Rotation();
            }
        }
    }

    // public void SpeedReset(float value)
    // {
    //     Invoke("Spreset", value);
    // }
    //
    // private void Spreset()
    // {
    //     Player.speed = 3f;
    // }
}
