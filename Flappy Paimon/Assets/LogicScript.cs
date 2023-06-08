using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public void addScore(int score){
        playerScore+= score;
        scoreText.text = playerScore.ToString();
    }

    [ContextMenu("Reset Score")]
    public void resetScore(){
        playerScore = 0;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    [ContextMenu("Call Game Over")]
    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
}
