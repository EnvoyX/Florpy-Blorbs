using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour{
    public static ScoreManager instance;
    public Text scoreText;
    public Text highscoreText;
    public BirdScript bird;
    int score = 0;
    int highscore = 0;
    public AudioSource dingSFX;
    public AudioSource coinCollected;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " Points";
        highscoreText.text = "Highscore: " + highscore.ToString();

        
    }
    public void addScore(int pointValue){
        score += pointValue;
        scoreText.text = score.ToString() + " Points";
        dingSFX.Play();
        if (highscore < score){
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void aliveScore(int pointValue){
        score += pointValue;
        scoreText.text = score.ToString() + " Points";
    }

    public void coinScore(int pointValue){
        score += pointValue;
        scoreText.text = score.ToString() + " Points";
        coinCollected.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(BirdScript.BirdInstance.birdIsAlive == true){
            aliveScore(1);
            
            
        }
    }
    
}
