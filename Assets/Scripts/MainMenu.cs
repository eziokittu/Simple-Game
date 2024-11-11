using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LevelStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelectMenu");
    }

    public void GameQuit()
    {
        Debug.Log("Quitting the game.");
        Application.Quit();
    }
}
