using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    public Text InGameScoreText;
    public Text HighScoreText;
    public GameObject GameOverUI;
    
    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        ScoreText.text = "Score : " + Score.ToString();
        InGameScoreText.text = Score.ToString();
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