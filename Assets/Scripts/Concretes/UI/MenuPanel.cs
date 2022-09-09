using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerGame.Managers;

namespace RunnerGame.UI
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartButton()
        {
            GameManager.Instance.LoadScene("Game");
        }

        public void ExitButton()
        {
            GameManager.Instance.ExitGame();
        }
    }

}
