using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //[SerializeField] private LayerMask _maskObs;
    //[SerializeField] private Transform _oldPosition;
    //[SerializeField] private Transform _PlayerBody;
    public Player Player;
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - Player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = Player.transform.position + _offset;
    }

    //private void FixedUpdate()
    //{
    //    RaycastHit hit;
    //    Vector3 trueTargetPosition = _PlayerBody.transform.position;
    //    if (Physics.Raycast(trueTargetPosition, _oldPosition.position - trueTargetPosition, out hit, Vector3.Distance(_oldPosition.position, trueTargetPosition), _maskObs))
    //    {
    //        transform.position = hit.point;
    //    }
    //    else
    //    {
    //        transform.position = _oldPosition.position;
    //    }
    //}
}
