using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public GameManager GameManager;
    public GameObject WinUI;
    public GameObject LoseUI;

    private GameObject a;

    private bool isWin = false;
    private bool isLose = false;
    private bool soundPlaying = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish") && (isLose != true) && (soundPlaying == false))
        {
            FindObjectOfType<AudioManager>().Play("LevelComplete");
            soundPlaying = true;
            WinUI.SetActive(true);
            isWin = true;
            GameManager.LevelComplete();
            // isWin = false;
        }
        else if (other.gameObject.CompareTag("Wall") && (isWin != true) && (soundPlaying == false))
        {
            FindObjectOfType<AudioManager>().Play("HitWall");
            FindObjectOfType<AudioManager>().Play("LevelFailed");
            soundPlaying = true;
            LoseUI.SetActive(true);
            isLose = true;
            GameManager.GameOver();
            // isLose = false;
        }
    }
}
