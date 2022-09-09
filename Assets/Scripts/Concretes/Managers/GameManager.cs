using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
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

        public void LoadScene(string sceneName)
        {
            StartCoroutine(LoadSceneAsync(sceneName));
        }

        IEnumerator LoadSceneAsync(string sceneName)
        {
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

        public void TurnMenu()
        {
            SceneManager.LoadScene(0);
        }

        public void ExitGame()
        {
            Debug.Log("Exit process is running");
            Application.Quit();
        }

    }

}

