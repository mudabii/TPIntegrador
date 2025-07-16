using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] private TMP_Text scoreText;
    private int score = 0;
    AudioSource coinAudio;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        coinAudio = GetComponent<AudioSource>();
        scoreText.text = "$" + score.ToString();
    }


    public void AddPoints(int points)
    {
        coinAudio.pitch = UnityEngine.Random.Range(1f, 1.3f);
        coinAudio.Play();
        score += points;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        scoreText.text = "$" + score.ToString();
    }
}
