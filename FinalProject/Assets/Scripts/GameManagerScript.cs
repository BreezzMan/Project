using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManagerScript : MonoBehaviour
{
    private static string LIVES_TEXT = "Lives: %";
    private static string SCORE_TEXT = "Score: %";

    public TextMeshProUGUI livesLabel;
    public TextMeshProUGUI scoreLabel;
    public GameObject gameOverPanel;

    public int lives = 5;
    public int score = 0;

    void Start()
    {
        lives = 5;
        score = 0;
    }

    private void FixedUpdate()
    {
        livesLabel.text = LIVES_TEXT.Replace("%", lives.ToString());
        scoreLabel.text = SCORE_TEXT.Replace("%", score.ToString());

        if (lives <= 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0; // Pause the game
        }

    }

    private void Update()
    {
        if (lives > 0)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1; // Resume the game
            gameOverPanel.SetActive(false);
            lives = 5;
            score = 0;
            RestartGame();
        }

    }

    void RestartGame()
    {
        SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

}
