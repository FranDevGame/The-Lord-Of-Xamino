using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject pauseMenuPanel;
    [SerializeField] bool pausedGame = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pausedGame)
            {
                RestartGame();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Pause()
    {
        pausedGame = true;
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
        pauseMenuPanel.SetActive(true);
     }

    public void RestartGame()
    {
        pausedGame = false;
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
        pauseMenuPanel.SetActive(false);
    }

    public void ReloadGame()
    {
        pausedGame = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Debug.Log("Cerrando juego");
        Application.Quit();
    }
}
