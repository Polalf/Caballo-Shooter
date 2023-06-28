using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreControl : MonoBehaviour
{
    public int highScore;
    public int score;
   
    public TMP_Text highScoreScreen;
    public TMP_Text scoreScreen;
    private void Start()
    {
        StartCoroutine(ContadorPuntaje());
        LoadScore();
    }
    private void Update()
    {
        scoreScreen.text = "Score: "+score.ToString();
        highScoreScreen.text = "High Score " + highScore.ToString();
        if(score > highScore)
        {
            highScore = score;
            SaveScore();
        }
    }
    void SaveScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
    }
    void LoadScore()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
    }
    IEnumerator ContadorPuntaje()
    {
        while(true)
        {
            score += 10;
            yield return new WaitForSeconds(1);
        }
        
    }
}
