using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerGame.Abstracts.Utilities
{
    public abstract class SingletonBehaviour<T> : MonoBehaviour
    {
       public static T Instance { get; private set; }

        public void SingletonThisObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }

            else
            {
                Destroy(this.gameObject);
            }
        }
    }

}
