using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
        public void QuitGame() 
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay 1");
    }

        public void TutorialScreen()
    {
        SceneManager.LoadScene("TutorialScreen");
    }

        public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}