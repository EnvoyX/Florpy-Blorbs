using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public ScoreManager scoreManager;  // cara 1
    public BirdScript bird;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Score Manager").GetComponent<ScoreManager>(); //cara 1
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.layer == 3 && bird.birdIsAlive == true){
            // scoreManager.addScore(1);  //cara 1
            ScoreManager.instance.addScore(1);   //cara 2
        }
        
    }
}
