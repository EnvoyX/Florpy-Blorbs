using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text coinText;
    private int coin = 0;
    
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Coin")){
            ScoreManager.instance.coinScore(10000);
            Destroy(collision.gameObject);
            Debug.Log("You got 10000 points!");
            coin++;
            coinText.text = "Coin: " + coin.ToString();
        }
    }
}
