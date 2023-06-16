using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    public GameObject point;
    public int points = 0;
    public TextMeshProUGUI scoreText;
    public int score;
    public TextMeshProUGUI scoreText2;

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);
        score = PlayerPrefs.GetInt("Highscore");
        scoreText2.text = $"Highscore: {score.ToString()}";
    }

    private void ShowPoints()
    {
        point.SetActive(true);
    }
    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void OnGameOver()
    {
        ShowLoseUI();
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        points++;
        scoreText.text = points.ToString();
    }

    public void UpdateScore2()
    {
        if(points>PlayerPrefs.GetInt("Highscore"))
        {
            score = points;
            PlayerPrefs.SetInt("Highscore", score);
            PlayerPrefs.Save();
        }
    }
}
