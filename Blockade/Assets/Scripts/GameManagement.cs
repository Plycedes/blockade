using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject finishLevelUI;

    public float restartDelay = 1f;
        
    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);
            FindObjectOfType<AudioManager>().Play("Error");
        }        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void FinishLevel()
    {
        finishLevelUI.SetActive(true);        
    }
        
}
