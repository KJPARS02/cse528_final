using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour{

        public Text scoreText;
        public Text highScoreText;

        public float scoreCount;
        public float highscoreCount;

        public float pointsPerSecond;

        public bool scoreIncreasing;
    // Start is called before the first frame update
    void Start()
    {   //save highscore even after closing game
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highscoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {   
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime; //increment score over time
        }

        if(scoreCount > highscoreCount)
        {
            highscoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highscoreCount);
        }
        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round (highscoreCount);



    }

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
