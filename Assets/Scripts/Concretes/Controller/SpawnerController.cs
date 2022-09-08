using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerGame.Controller
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] EnemyController _enemyPrefab;

        [Range(0.1f, 5.00f)] float _min = 0.1f;

        [Range(6.0f, 10.0f)] float _max = 10f;

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
            EnemyController newEnemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
            newEnemy.transform.parent = this.transform;  

            _currentSpawnTime = 0f;
            GetRandomMaxTime();
        }

        private void GetRandomMaxTime()
        {
            _maxSpawnTime=Random.Range(_min, _max);
        }
    }

}
