using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;
    public Image pausedPanel;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        pausedPanel.gameObject.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        isPaused = false;
        pausedPanel.gameObject.SetActive(false);
    }
}
