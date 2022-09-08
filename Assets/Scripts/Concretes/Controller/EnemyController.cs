using RunnerGame.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerGame.Controller
{
    public class EnemyController : MonoBehaviour
    {
        VerticalMovement verticalMovement;

        [Range(1f, 10f)]
        [SerializeField] float _enemyMoveSpeed = 5f;

        public float EnemyMoveSpeed => _enemyMoveSpeed; 



        private void Awake()
        {
            verticalMovement = new VerticalMovement(this);
        }

        private void FixedUpdate()
        {
            verticalMovement.FixedTick();
        }
    }

}
