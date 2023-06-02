using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isRunning = true;
    public GameObject pauseMenu;
    public GameObject scoreUI;

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape)&&(isRunning)) Pause();
        else if(Input.GetKeyDown(KeyCode.Escape)&&!(isRunning)) Resume();
    }
    
    public void ResetGame()
    {
        SceneManager.LoadScene("Scene");
        isRunning=true;
        Time.timeScale=1f;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        isRunning=true;
        Time.timeScale=1f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        scoreUI.SetActive(true);
        isRunning=true;
        Time.timeScale=1f;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        scoreUI.SetActive(false);
        isRunning=false;
        Time.timeScale=0f;
    }

}
