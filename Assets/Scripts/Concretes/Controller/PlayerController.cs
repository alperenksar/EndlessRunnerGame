using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerGame.Movements;

namespace RunnerGame.Controller
{
    public class PlayerController : MonoBehaviour
    {
        [Header("HorizontalMover")]
          [SerializeField] float _horizontalDirection = 0f;
          [SerializeField] float _moveSpeed = 10f;
          HorizontalMovements _horizontalMovements;

        [Header("JumpMover")]
          [SerializeField] float _jumpForce = 10f;
          [SerializeField] bool _isJump;
          JumpMovements _jumpMovements;
        


        private void Awake()
        {
            _horizontalMovements = new HorizontalMovements(this);
            _jumpMovements = new JumpMovements(this);
        }

        private void FixedUpdate()
        {
            _horizontalMovements.TickFixed(_horizontalDirection, _moveSpeed);

            if (_isJump)
            {
                _jumpMovements.TickFixed(_jumpForce);
            }

            _isJump = false;


        }


    }

}
