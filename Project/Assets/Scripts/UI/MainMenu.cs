using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameProject.UI
{
    public class MainMenu : Screen
    {
        [SerializeField]
        private GameObject instructionsScreen;

        [SerializeField]
        private GameObject creditsScreen;

        public void StartGame()
        {
            GameManager.Instance.LoadNewGame();
        }

        public void OpenInstructions()
        {
            instructionsScreen.SetActive(true);
        }

        public void CloseInstructions()
        {
            instructionsScreen.SetActive(false);
        }

        public void OpenCredits()
        {
            creditsScreen.SetActive(true);
        }

        public void CloseCredits()
        {
            creditsScreen.SetActive(false);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
