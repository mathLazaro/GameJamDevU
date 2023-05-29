using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public TextMeshProUGUI scoreText;

    public static GameController instance;
    
    private void Start() 
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text=totalScore.ToString();
    }

}
