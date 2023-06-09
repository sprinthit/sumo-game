using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        CountDown.isPaused = true;
        PauseMenu.isPaused = false;
        SceneManager.LoadScene("2Player"); 
    }
    public void PlayerVSAI()
    {
        CountDown.isPaused = true;
        PauseMenu.isPaused = false;
        SceneManager.LoadScene("VSAI");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
