using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerGame.Controller;

namespace RunnerGame.Movements
{
    public class HorizontalMovements 
    {
        PlayerController _playerController;
        float _moveSpeed;
        float _moveBound;
    
        
        public HorizontalMovements(PlayerController playerController)
        {
            _playerController = playerController;
            _moveSpeed=_playerController.MoveSpeed;
            _moveBound=_playerController.MoveBoundary;
        }

        public void TickFixed(float horizontal)
        {
            if (horizontal == 0) return;

            _playerController.transform.Translate(Vector3.right * horizontal * _moveSpeed*Time.deltaTime);

            float xboundary = Mathf.Clamp(_playerController.transform.position.x, -_moveBound, _moveBound);
            _playerController.transform.position = new Vector3(xboundary, _playerController.transform.position.y, _playerController.transform.position.z);

            
        }
    }

}

