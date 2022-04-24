using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject resumeMenuUI;

    public void ResumeButton()
    {
        pauseMenuUI.SetActive(false);
        resumeMenuUI.SetActive(true);
        Time.timeScale = 1;
    }

    public void PauseButton()
    {
        pauseMenuUI.SetActive(true);
        resumeMenuUI.SetActive(false);
        Time.timeScale = 0;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
