using RunnerGame.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerGame.Movements
{
    public class VerticalMovement 
    {
        EnemyController _enemyController;
        float _moveSpeed;

        public VerticalMovement(EnemyController enemyController)
        {
            _enemyController = enemyController;
            _moveSpeed = _enemyController.EnemyMoveSpeed;
        }

        public void FixedTick(float Vertical = 1)
        {
            _enemyController.transform.Translate(-Vector3.forward * Vertical*_moveSpeed * Time.deltaTime);
        }
    }

}
