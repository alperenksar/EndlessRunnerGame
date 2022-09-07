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

        public JumpMovements(PlayerController playerController)
        {
            Rigidbody=playerController.GetComponent<Rigidbody>();
        }

        public void TickFixed(float Jumpforce)
        {
            if (Rigidbody.velocity.y != 0) return;

            Rigidbody.velocity = Vector3.zero;
            Rigidbody.AddForce(Vector3.up * Jumpforce * Time.deltaTime);
        }
        
    }

}

