using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
