using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Gameover : MonoBehaviour
{
    [SerializeField] private GameObject ButtonMenu;
    [SerializeField] private GameObject WaitMenu;

    private static GameObject BM;
    private static GameObject WT;

    private void Awake() 
    {
        BM = ButtonMenu;
        WT = WaitMenu;
    }
    
    public static void Game_over()
    {
        Time.timeScale = 0f;
        BM.SetActive(false);
        WT.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void ExitMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
