using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private static bool isPaused = false;
    public GameObject pauseMenu;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            if (isPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Menu()
    {
        isPaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void Quit()
    {
        UnityEditor.EditorApplication.ExitPlaymode();
    }
}
