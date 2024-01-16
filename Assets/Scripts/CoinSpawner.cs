using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 12;
    public float XdistanceOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer += Time.deltaTime;
        }
        else{
            SpawnCoin();
            timer = 0;
        }
    }

    void SpawnCoin(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float closestPoint = transform.position.x - heightOffset;
        float farthestPoint = transform.position.x + heightOffset;
        Instantiate(coin, new Vector3(Random.Range(closestPoint,farthestPoint), Random.Range(lowestPoint,highestPoint),0), transform.rotation);

    }
}
