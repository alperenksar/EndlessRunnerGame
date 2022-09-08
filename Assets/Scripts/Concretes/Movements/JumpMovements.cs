using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerGame.Controller;

//Rigidbody ile zýplama

namespace RunnerGame.Movements
{
    public class JumpMovements : MonoBehaviour
    { 
        private Rigidbody Rigidbody;

        public bool CanJump => Rigidbody.velocity.y != 0f;

        public JumpMovements(PlayerController playerController)
        {
            Rigidbody=playerController.GetComponent<Rigidbody>();
        }

        public void TickFixed(float Jumpforce)
        {
            if (CanJump) return;

            Rigidbody.velocity = Vector3.zero;
            Rigidbody.AddForce(Vector3.up * Jumpforce * Time.deltaTime);
        }
        
    }

}

