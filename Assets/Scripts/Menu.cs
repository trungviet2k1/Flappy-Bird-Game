using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text HighScore;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        HighScore.text = "High Score : " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void Play()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Quit()
    {
        Application.Quit();
    }
}