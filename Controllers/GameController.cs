using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using DefaultNamespace.Bonuses;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public sealed class GameController : MonoBehaviour
{
    private InteractiveObject[] _interactiveObjects;
    private RandomColor _rndcolor;
    private Reference _reference;
    [SerializeField] private BonusData _data;


    private void Start()
    {
        new GameInt(_data);
    }

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
            if (o is TrapBadBonus trapBadBonus)
            {
                trapBadBonus.End += Triggered;
                trapBadBonus.End += End;
            }
        }
        _reference = new Reference();
        _reference.RestartButton.onClick.AddListener(RestartGame);
        _reference.RestartButton.gameObject.SetActive(false);
    }

    private void RestartGame()
    {
        _reference.EndGame.gameObject.SetActive(false);
        _reference.RestartButton.gameObject.SetActive(false);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    private void End()
    {
        _reference.EndGame.gameObject.SetActive(true);
        _reference.RestartButton.gameObject.SetActive(true);
        Time.timeScale = 0f;
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
