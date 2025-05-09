using UnityEngine;

public class Script_switch : MonoBehaviour
{
    public void BackToSelection()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Switch");
    }

    public void Scene1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene1");
    }

    public void Scene2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene2");
    }

    public void Scene3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene3");
    }
}
