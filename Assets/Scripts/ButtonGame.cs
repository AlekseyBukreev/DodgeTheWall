
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonGame : MonoBehaviour
{
    private bool CheakPause = false;
    public void GoMenu()
    {
        Time.timeScale = 1f;
        CheakPause = false;
        SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        if(CheakPause == false)
        {
            Time.timeScale = 0f;
            CheakPause = true;
        }
        else if (CheakPause == true)
        {
            Time.timeScale = 1f;
            CheakPause = false;
        }
    }

}
