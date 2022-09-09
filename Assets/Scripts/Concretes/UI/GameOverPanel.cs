using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerGame.Managers;

namespace RunnerGame.UI
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
            GameManager.Instance.LoadScene("Game");
        }

        public void NoButton()
        {
            GameManager.Instance.TurnMenu();
        }
    }

}
