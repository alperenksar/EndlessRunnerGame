using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerGame.Movements;
using RunnerGame.Abstracts.Input;
using RunnerGame.Input;
using UnityEngine.InputSystem;

namespace RunnerGame.Controller
{
    public class PlayerController : MonoBehaviour
    {
        [Header("HorizontalMover")]
          [SerializeField] float _moveBound = 4.5f;
          [SerializeField] float _moveSpeed = 10f;
          HorizontalMovements _horizontalMovements;


        [Header("JumpMover")]
          [SerializeField] float _jumpForce = 10f;
          JumpMovements _jumpMovements;

        IInputReader _input;

        float _horizontal;
        bool _isJump;

        public float MoveSpeed => _moveSpeed;

        public float MoveBoundary => _moveBound;
        


        private void Awake()
        {
            _horizontalMovements = new HorizontalMovements(this);
            _jumpMovements = new JumpMovements(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            _horizontal = _input.Horizontal;

            if (_input.IsJump)
            {
                _isJump = true;
            }
        }

        private void FixedUpdate()
        {
            _horizontalMovements.TickFixed(_horizontal);

            if (_isJump)
            {
                _jumpMovements.TickFixed(_jumpForce);
            }

            _isJump = false;
        }

      


    }

}
