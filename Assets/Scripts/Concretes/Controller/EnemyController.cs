using RunnerGame.Managers;
using RunnerGame.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerGame.Abstracts.Controllers;

namespace RunnerGame.Controller
{
    public class EnemyController : MonoBehaviour , IEntityController
    {
        VerticalMovement verticalMovement;

        [Range(1f, 30f)]
        [SerializeField] float _enemyMoveSpeed = 30f;

        [SerializeField] float _maxLifeTime = 10f;

        public float EnemyMoveSpeed => _enemyMoveSpeed;

        float CurrentLifeTime = 0f;



        private void Awake()
        {
            verticalMovement = new VerticalMovement(this);
        }

        private void Update()
        {
            CurrentLifeTime += Time.deltaTime;

            if (CurrentLifeTime > _maxLifeTime)
            {
                CurrentLifeTime = 0f;
                KillYourSelf();
            }
        }

        private void FixedUpdate()
        {
            verticalMovement.FixedTick();
        }

        void KillYourSelf()
        {
            EnemyManager.Instance.SetPool(this);
        }

    }

}
