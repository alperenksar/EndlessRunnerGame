using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerGame.Abstracts.Utilities;
namespace RunnerGame.Managers
{
    public class GameManager : SingletonBehaviour<GameManager>
    {
        private void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0f;
        }

    }

}

