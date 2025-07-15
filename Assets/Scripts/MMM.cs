using UnityEngine;
using UnityEngine.SceneManagement;

public class MMM : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
