using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Light myLight;
    public GameObject player;

    public float nextLevelDelay = 2f;
    public float levelRestartDelay = 2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && (PauseMenu.gameIsPaused == false))
        {
            myLight.enabled = !myLight.enabled;
        }
    }

    public void LevelComplete()
    { 
        Invoke("NextLevel", nextLevelDelay);
    }

    public void GameOver()
    {
        Invoke("Restart", levelRestartDelay);
    }

    private void NextLevel()
    {
        if (GameObject.Find("WinUI") == true)
        {
            GameObject.Find("WinUI").SetActive(false);
        }
        else
        {
            Debug.Log("Cant find the GUI for WIN and LOSE");

        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
