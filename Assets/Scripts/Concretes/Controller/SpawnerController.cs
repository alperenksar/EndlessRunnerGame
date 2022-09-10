using RunnerGame.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerGame.Controller
{
    public class SpawnerController : MonoBehaviour
    {

        [Range(0.1f, 2.00f)] float _min = 0.1f;

        [Range(2.0f, 6.0f)] float _max = 10f;

        float _maxSpawnTime ;
        float _currentSpawnTime = 0f;

        private void OnEnable()
        {
            GetRandomMaxTime();
        }

        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;
            if (_currentSpawnTime > _maxSpawnTime)
            {
                Spawn();
            }
        }

        void Spawn()
        {
            EnemyController newEnemy = EnemyManager.Instance.GetPool();
            newEnemy.transform.parent = this.transform;
            newEnemy.transform.position = this.transform.position;
            newEnemy.gameObject.SetActive(true);

            _currentSpawnTime = 0f;
            GetRandomMaxTime();
        }

        private void GetRandomMaxTime()
        {
            _maxSpawnTime=Random.Range(_min, _max);
        }
    }

}
