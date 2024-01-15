using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public AudioSource fartSFX;
    void Start()
    {

    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
        Time.timeScale = 1f;
        PauseMenu.instancePause.GameIsPaused = false; 
        Debug.Log("You Restarted!");     
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
        deathSound();  
        Time.timeScale = 0f;
        PauseMenu.instancePause.GameIsPaused = true;
        Debug.Log("You Died!");
    }
    public void deathSound(){
        fartSFX.Play();  
        Debug.Log("Death Fart sound played!");
    }

    public void backToMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Loading Menu....");
    }
}
