using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public static BirdScript BirdInstance;
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    private void Awake(){
        BirdInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true){
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if(transform.position.y > 16 || transform.position.y < -16){
            logic.gameOver();
            birdIsAlive = false;
            transform. position = new Vector3(0f, 0f, 0f); 
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
            logic.gameOver();
            birdIsAlive = false;
    } 
}
