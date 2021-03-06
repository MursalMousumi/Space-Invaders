using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static float playerScore = 0;

    public static float playerHighScore;

    public TextMeshProUGUI scoreText;
    //private TextMeshProUGUI highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        playerScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (playerHighScore > playerScore)
        {
            playerHighScore = playerScore;
        }
        scoreText.text = $"Score: {playerScore:0000}" + $"\nHigh Score: {playerHighScore:0000}";
    }
}