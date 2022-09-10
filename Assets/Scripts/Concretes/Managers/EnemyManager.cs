using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerGame.Controller;
using RunnerGame.Abstracts.Utilities;
using System;

namespace RunnerGame.Managers
{
    public class EnemyManager : SingletonBehaviour<EnemyManager>
    {
        [SerializeField] EnemyController _enemyPrefab;

        Queue<EnemyController> _enemies=new Queue<EnemyController> ();

        private void Awake()
        {
            SingletonThisObject(this);
        }

        private void Start()
        {
            InitializePool();
        }

        private void InitializePool()
        {
            for (int i = 0; i < 10; i++)
            {
                EnemyController newEnemy = Instantiate(_enemyPrefab);
                newEnemy.gameObject.SetActive(false);
                newEnemy.transform.parent = this.transform;

                _enemies.Enqueue(newEnemy);
            }
        }

        public void SetPool(EnemyController enemyController)
        {
            enemyController.gameObject.SetActive(true);
            enemyController.transform.parent =this.transform;
            _enemies.Enqueue (enemyController);
        }

        public EnemyController GetPool()
        {
            if (_enemies.Count == 0)
            {
                InitializePool();
            }

            return _enemies.Dequeue();
        }
    }

}
