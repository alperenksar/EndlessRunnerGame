using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerGame.Controller;

namespace RunnerGame.Movements
{
    public class HorizontalMovements 
    {
        PlayerController _playerController;
        
        public HorizontalMovements(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void TickFixed(float horizontal, float movespeed)
        {
            if (horizontal == 0) return;

            _playerController.transform.Translate(Vector3.right * horizontal * movespeed*Time.deltaTime);

            
        }
    }

}

