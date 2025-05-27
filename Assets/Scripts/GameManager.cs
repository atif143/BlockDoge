using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;

    bool gameStarted =false;
    public GameObject ScText;

    public GameObject tapText;
    public TextMeshProUGUI scoreText;

 
    int score;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)&& !gameStarted)
        {
            StartSpawning();
            gameStarted = true;
            tapText.SetActive(false);
            ScText.SetActive(true);
        }
    }

    private void StartSpawning()
    {
        InvokeRepeating("spawnBlock", 0.5f,spawnRate);
    }

    void spawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x=Random.Range(-maxX, maxX);

        Instantiate(block, spawnPos,Quaternion.identity);

        score++;
        scoreText.text=score.ToString();
    }
}
