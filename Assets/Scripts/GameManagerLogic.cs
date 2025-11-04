using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerLogic : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;
    public GameObject gameOverScreen;

    void Start()
    {
        updateHighScore();
    }

    [ContextMenu("Increase Dih Size")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        updateHighScore();
    }
    public void addCurrency(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 1);
        scoreText.text = (PlayerPrefs.GetInt("money").ToString());
    }

    [ContextMenu("Reset Score")]
    public void resetScore()
    {
        PlayerPrefs.DeleteKey("highScore");
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        updateHighScore();
        gameOverScreen.SetActive(true);
    }

    public void updateHighScore()
    {
        if (playerScore > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", playerScore);
            highScoreText.color = new UnityEngine.Color(255, 255, 0);
        }

        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("highScore").ToString();
    }
}
