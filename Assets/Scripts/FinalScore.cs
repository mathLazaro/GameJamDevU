using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public int totalScore;
    public TextMeshProUGUI scoreText;

    private void Start() {
        totalScore=Info.score;
        scoreText.text=totalScore.ToString();
    }

}
