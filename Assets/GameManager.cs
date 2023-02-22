using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    public int score = 0;
    [SerializeField] private GameObject brickEnemy;
    private int brickTotal;
    private bool isGameOver = false;
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        brickTotal = brickEnemy.transform.childCount;
        if (brickTotal == 0 && isGameOver == false)
        {
            Debug.Log("You Win");
            isGameOver = true;
        }
    }
}
