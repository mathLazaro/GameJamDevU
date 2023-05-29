using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Scene");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
