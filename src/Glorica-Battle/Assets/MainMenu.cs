using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Switch");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting...");
    }

    public void Settings()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Settings");
    }

    public void Store()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Store");
    }

    public void Instructions()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Instructions");
    }

    public void BackToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameMenu");
    }
}
