using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using DefaultNamespace.Bonuses;
using DefaultNamespace.Model;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public sealed class GameController : MonoBehaviour
{
    private InteractiveObject[] _interactiveObjects;
    private RandomColor _rndcolor;
    private Reference _reference;
    private BonusInput _bonusInput;
    [SerializeField] private BonusData _data;
    private InputController _inputController;
    private CameraController _cameraController;
    private ListExecuteObject _interactiveObject;

    private void Start()
    {
        new GameInt(_data);
    }

    private void Awake()
    {
        _interactiveObject = new ListExecuteObject();
        
        _reference = new Reference();
        
        _inputController = new InputController(_reference.HeroPlayer);
        _interactiveObject.AddExecuteObject(_inputController);
        
        _cameraController = new CameraController(_reference.HeroPlayer.transform, _reference.MainCamera.transform);
        _interactiveObject.AddExecuteObject(_cameraController);
        
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

        _reference.RestartButton.onClick.AddListener(RestartGame);
        _reference.RestartButton.gameObject.SetActive(false);
        
        BonusBase bonus = null;
        _bonusInput = new BonusInput(bonus);
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
        for (var i = 0; i < _interactiveObject.Length; i++)
        {
            var interactiveObject = _interactiveObject[i];

            if (interactiveObject == null)
            {
                continue;
            }
            interactiveObject.Execute();
        }

    }
}
