using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public float spawnTime;
    public GameObject enemyPrefab;
    public GameObject spawnPos;

    int score;
    public TMP_Text scoreText;
    
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime; 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > spawnTime)
        {
            timer = 0;
            Vector3 spawnAt = spawnPos.transform.position;
            spawnAt.x += Random.Range(-2, 2);
            Instantiate(enemyPrefab, spawnAt, Quaternion.identity);
        }
    }
    
    public void IncScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }
}
