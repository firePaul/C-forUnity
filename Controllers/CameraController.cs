using System.Collections;
using System.Collections.Generic;
using System.Data;
using DefaultNamespace.Bonuses;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Player Player;
    private Vector3 _offset;
   

    private void Start()
    {
        if (Player==null)
        {
            throw new DataException($"Player not found");
        }
        _offset = transform.position - Player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = Player.transform.position + _offset;
    }
}
