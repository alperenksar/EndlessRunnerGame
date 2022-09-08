using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using RunnerGame.Abstracts.Input;

namespace RunnerGame.Input
{
    public class InputReader : IInputReader
    {
        PlayerInput _playerInput;

        public float Horizontal { get; private set; }

        public bool IsJump { get; private set; }

        public InputReader(PlayerInput playerInput)
        {        
            _playerInput = playerInput;

            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;

            _playerInput.currentActionMap.actions[1].started += OnJumpMove;
            _playerInput.currentActionMap.actions[1].canceled += OnJumpMove;


        }

        void OnHorizontalMove(InputAction.CallbackContext context)
        {
            Horizontal = context.ReadValue<float>();
        }

        void OnJumpMove(InputAction.CallbackContext context)
        {
            IsJump = context.ReadValueAsButton();
        }


    }

}
