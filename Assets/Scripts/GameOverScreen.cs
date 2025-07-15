using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;
    void Start()
    {
        Cursor.visible = false;
        GameOverPanel.SetActive(false);
    }

    public void ActiveScreenLose()
    {
        Cursor.visible = true;
        Time.timeScale = 0f;
        GameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}
