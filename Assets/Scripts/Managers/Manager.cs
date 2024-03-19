using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    public int Score;
    public Text ScoreText;
    public Text InGameScoreText;
    public Text HighScoreText;
    public GameObject GameOverUI;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        InGameScoreText.text = "Score : " + Score.ToString();
        ScoreText.text = Score.ToString();
        HighScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);

        if (Score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", Score);
        }

        GameObject.FindWithTag("Player").SetActive(false);
        Time.timeScale = 0f;
    }
}