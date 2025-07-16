using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;
    AudioSource deathSound;
    void Start()
    {
        Cursor.visible = false;
        GameOverPanel.SetActive(false);
        deathSound = GetComponent<AudioSource>();
    }

    public void ActiveScreenLose()
    {
        deathSound.Play();
        Cursor.visible = true;
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
        SceneManager.LoadScene("MainMenu");
    }
}
