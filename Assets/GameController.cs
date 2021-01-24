 
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GamePlayUIController getUiController;
    static bool isGameOver = false ;
    private void Awake()
    {
        isGameOver = false;
        Time.timeScale = 1f;
    }
    public static void GameOver()
    {
        isGameOver = true;
    }
    private void Update()
    {
        if (isGameOver)
        {
            getUiController.showGameOver(true);
            Time.timeScale = 0f;
            isGameOver = false;
        }
    }
    public void Pause()
    {
           getUiController.showpause(true);
           Time.timeScale = 0f;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
}
