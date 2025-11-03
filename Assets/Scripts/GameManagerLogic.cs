using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerLogic : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;

    void Start()
    {
 
    }

    [ContextMenu("Increase Dih Size")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("highScore") + 1);
        scoreText.text = (PlayerPrefs.GetInt("highScore").ToString());
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
        gameOverScreen.SetActive(true);
    }
}
