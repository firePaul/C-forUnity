﻿using Interface;
using UnityEngine;

namespace DefaultNamespace
{
    public sealed class InputController : IExecute
    {
        private readonly Player _player;

        public InputController(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Move(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        }
    }
}
