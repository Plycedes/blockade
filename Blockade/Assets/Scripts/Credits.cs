using UnityEngine;

public class Credits : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("gameWin");
    }

    public void ExitGame()
    {
        Application.Quit();
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
}
