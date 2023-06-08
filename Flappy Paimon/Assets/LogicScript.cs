using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Add Score")]
    public void addScore(int score){
        playerScore+= score;
        scoreText.text = playerScore.ToString();
    }

    [ContextMenu("Reset Score")]
    public void resetScore(){
        playerScore = 0;
        scoreText.text = playerScore.ToString();
    }
}
