using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public void Load_Game()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Menu()
    {
        Debug.Log("Load Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void Credits()
    {
        Debug.Log("Load Menu");
        SceneManager.LoadScene("Credits");
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}
