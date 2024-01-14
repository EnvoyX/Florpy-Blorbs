using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public BirdScript bird;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    public AudioSource fartSFX;
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd){
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
        deathSound();  
    }
    public void deathSound(){
        fartSFX.Play();  
    }
}
